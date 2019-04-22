package Timings;

public class EventData
{
	private String eventName ;
	private String eventCategory;
	private int eventLaps = -1;
	

	public void setEventLaps(int eventLaps) 
	{
		this.eventLaps = eventLaps;
	}
	
	public int getEventLaps() 
	{
		return eventLaps;
	}
	
	public String getEventName() 
	{
		return eventName;
	}
	
	public void setEventName(String eventName) 
	{
		this.eventName = eventName;
	}
	
	public String getEventCategory() 
	
	{
		return eventCategory;
	}
	
	public void setEventCategory(String eventCategory) 
	{
		this.eventCategory = eventCategory;
	}
}
