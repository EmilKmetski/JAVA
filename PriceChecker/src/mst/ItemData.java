package mst;

public class ItemData 
{
	private String itemName;
	private String itemMeasure;
	private double itemPrice;
	private ImageData itemImage;
	public ImageData getItemImage() {
		return itemImage;
	}
	public void setItemImage(ImageData itemImage) {
		this.itemImage = itemImage;
	}
	public String getItemName() {
		return itemName;
	}
	public void setItemName(String itemName) {
		this.itemName = itemName;
	}
	public String getItemMeasure() {
		return itemMeasure;
	}
	public void setItemMeasure(String itemMeasure) {
		this.itemMeasure = itemMeasure;
	}
	public double getItemPrice() {
		return itemPrice;
	}
	public void setItemPrice(double itemPrice) {
		this.itemPrice = itemPrice;
	}	
}
