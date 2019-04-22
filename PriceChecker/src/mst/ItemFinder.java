package mst;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.io.InputStream;
import java.util.Properties;

public class ItemFinder 
{
	private static String sqlServerName,sqlServerUser, sqlServerUserPass,sqlDBName,picturesDirectory;
	
	public ItemFinder()
	{
		getConfigData();		
	}
	//read configuration data from properties file dbConn
	public static void getConfigData() 
	{
		Properties prop = new Properties();
		InputStream input = null;
		try {
			input = new FileInputStream("E:\\Projects\\Java\\MicroinvestPriceChecker\\WebContent\\WEB-INF\\conf\\dbConn.properties");

			// load a properties file
			prop.load(input);
			// get the property value and print it out
			sqlServerName = prop.getProperty("SERVER_NAME");
			//System.out.println(sqlServerName);
			sqlDBName=prop.getProperty("DB_NAME");
			//System.out.println(sqlDBName);			
			sqlServerUser = prop.getProperty("SQL_USER");
			//System.out.println(sqlServerUser);						
			sqlServerUserPass = prop.getProperty("SQL_PASS");
			//System.out.println(sqlServerUserPass);	
			picturesDirectory = prop.getProperty("PIX_DIR");
			//System.out.println(picturesDirectory);						
			
		}
		catch (IOException ex) 
		{
			ex.printStackTrace();
		} 
		finally 
		{
			if (input != null) 
			{
				try 
				{
					input.close();
				}
				catch (IOException e) 
				{
					e.printStackTrace();
				}
			}
		}
	}
	
	 public static void main (String args[])
	 {
//		 	String test = "SB:123456";
//		 	System.out.println(test.substring(0, 3));
//		 	System.out.println(test.length());
//			if((test.substring(0, 3).equals("SB:")) && (test.length() > 3))
//			{						
//			String myBarcode = test.substring(3,test.length()); 
//			
//			System.out.println("Message Received:");
//			System.out.println("Searched Item Barcode: " + myBarcode);
//			//System.out.println(msg);					
//			}		
//	     String str = "abc";
//	  
//
//
//	     //System.out.println("abc");
//	     String cde = "cde";
//	     //System.out.println("abc" + cde);
//	     
//	     String c = "abc".substring(0,1);
//	     System.out.println(c);
//	     String d = cde.substring(1, 2);
//	     System.out.println(d);
//		 getConfigData();
//		 
//		 ItemFinder myfinder = new ItemFinder();		 
//		 try {
//			ArrayList<ItemData> myItemsInfo = myfinder.findItemsByBarcode("20000011");			
//			for(int i = 0; i < myItemsInfo.size();i++)
//			{
//				ItemData currentItem = myItemsInfo.get(i);
//				System.out.println("Item Name: " + currentItem.getItemName());
//				System.out.println("Item Measure: " + currentItem.getItemMeasure());
//				System.out.println("Item Price: " + currentItem.getItemPrice());
//				System.out.println("Item Image String: " + currentItem.getItemImage().getImageStringData());
//				System.out.println("Item Image Type: " + currentItem.getItemImage().getImageType());
//			}
//		} catch (SQLException e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}  
	 } 	 

	 public ArrayList<ItemData> findItemsByBarcode(String barcode) throws SQLException
	 {	
		   ArrayList<ItemData> myFoundItems = new ArrayList<ItemData>();
		   //Returns result form the databse for selected barcode
		   
		   String db_connect_string = "jdbc:sqlserver://"+sqlServerName+":1433;databaseName="+sqlDBName;
	       String db_userid = sqlServerUser;
	       String db_password = sqlServerUserPass;
	       String sqlQuery= "Select name, measure1, Round(PriceOut2,3),code from Goods where BarCode1 like '%"+barcode+"%' or BarCode2 like '%"+barcode+"%' or BarCode3 like '%"+barcode+"%'";
    		 
	      try {
	         Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
	         Connection conn = DriverManager.getConnection(db_connect_string,
	                  db_userid, db_password);         
	      
	         Statement statement = conn.createStatement();
	         ResultSet myQueryResult = statement.executeQuery(sqlQuery);
	         
	         while(myQueryResult.next())
			{
				   //create item data object
				   ItemData myItem = new ItemData();
				   ImageData myItemImage = new ImageData();
				   String imageDataString = "";
				   
				   myItem.setItemName(myQueryResult.getString(1));				   
				   myItem.setItemMeasure(myQueryResult.getString(2));				   
				   myItem.setItemPrice( myQueryResult.getDouble(3));
				   myItemImage.setImageType("jpg");
				   //Sets Image data file location
				   myItemImage.setImageLocation( picturesDirectory + myQueryResult.getString(4) + ".jpg" );
				   
				   File file = new File(myItemImage.getImageLocation());
        		   try {
						/*
						 * Reading a Image file from file system
						 */
						FileInputStream imageInFile = new FileInputStream(file);
						byte imageData[] = new byte[(int)file.length()];
						imageInFile.read(imageData);
						/*
						 * Converting Image byte array into Base64 String 
						 */
						imageDataString = ImageManipulation.encodeImage(imageData);						
						imageInFile.close();		
					} catch (FileNotFoundException e) {
						System.out.println("Image not found" + e);
					} catch (IOException ioe) {
						System.out.println("Exception while reading the Image " + ioe);
					}
        		   //adds Byte64 image string to item image data
        		   myItemImage.setImageStringData(imageDataString);
				   myItem.setItemImage(myItemImage);
				   
				   //adds found items in the array list of items
				   myFoundItems.add(myItem);				   
			   }
	         conn.close();	         
	      } 
	      catch (Exception e) 
	      {
	    	  e.printStackTrace();
	      }   
		  return myFoundItems;
	   }
}
