package Timings;
import java.util.ArrayList;
public class AllRiders 
{
	//Създавеме лист от Състезатели
	private ArrayList<RiderData> myRidersList = new ArrayList<RiderData>();
	 
	public ArrayList<RiderData> getMyRidersList() 
	{
		return myRidersList;
	}
	//метод който добавя състезател
	public void AddMyRider(RiderData myCurrentRider)
	{
		this.myRidersList.add(myCurrentRider);
	}
	//метод който връща броя на състезателите
	public int getRidersCount() 
	{
		return myRidersList.size();
	}
	//метод който генерира таблицата за всички участващи състезатели
	public String GenerateRidersReport()
	{	
		String printData ="";
	    for (int i = 0; i < getRidersCount(); i++) 
	    {
			printData += myRidersList.get(i).getRiderAllData(false);
		}
		return printData;
	}
}
