package Timings;

public class RiderData extends EventData 
{	
	private String riderNames = "не е зададен";
	private int riderAge = 0;
	private String riderTeam = "не е зададен";
	private float eventTax = 0.00f;
	//Променлива която определя дали нашия състезател е платил
	private boolean paymentStatus  = false;
	
	public String getRiderNames() 
	{
		return riderNames;
	}
	public void setRiderNames(String riderNames) 
	{
		this.riderNames = riderNames;
	}
	public String getCategoryName() 
	{	
		return getEventCategory();
	}
	public void setCategoryName(String categoryName) 
	{
		setEventCategory(categoryName);
	}
	public int getRiderAge() 
	{
		return riderAge;
	}
	public void setRiderAge(int riderAge) 
	{
		this.riderAge = riderAge;
	}
	public String getRiderTeam() 
	{
		return riderTeam;
	}
	public void setRiderTeam(String riderTeam) 
	{
		this.riderTeam = riderTeam;
	}
	public float getEventTax() 
	{
		return eventTax;
	}
	public void setEventTax(float eventTax) 
	{
		this.eventTax = eventTax;
	}
	public boolean getPaymentStatus() 
	{
		return paymentStatus;
	}
	public void setPaymentStatus(boolean paymentStatus) 
	{
		this.paymentStatus = paymentStatus;
	}

	public String getRiderAllData(boolean genTable)
	{
		String payment;
		String tableheader;
		String tableEnd;
		if (genTable == true)
		{
			//Имена
			//Категория
			//Години
			//Отбор
			//Такса
			//Състезание
			//Стаус на плащането
		    //Време на финалнал
			//Изрисуваме хедъра на таблицата за резултатите.
			tableheader = "<table>"   
					+"<thead class=\"ui-widget-header\">"
					+"<tr>"
				    +"<th align = \"center\">Имена</th>"
				    +"<th align = \"center\">Категория</th>"
				    +"<th align = \"center\">Години</th>"
				    +"<th align = \"center\">Отбор</th>"
				    +"<th align = \"center\">Такса</th>"
				    +"<th align = \"center\">Състезание</th>"
				    +"<th align = \"center\">Стаус на плащането</th>"
				    +"<th align = \"center\">Обиколки</th>"	
				    +"</tr>"
				    +"</thead>"
				    +"<tbody class=\"ui-widget-content\">";
			tableEnd = "</table>";
		}
		else
		{
			tableheader=" ";
			tableEnd = " ";
		}
		if(paymentStatus)
		{
			payment = "Да";
		}
		else
		{
			payment = "Не";
		}
		String myst = Integer.toString(getEventLaps());
		
		return tableheader 
		//изрисуваме ред от таблицата за резултатите		
	    +"<tr>"
	    +"<td align = \"center\">"+ riderNames +"</td>"
	    +"<td align = \"center\">"+ getCategoryName( )+"</td>"
	    +"<td align = \"center\">"+ riderAge +"</td>"
	    +"<td align = \"center\">"+ riderTeam +"</td>"
	    +"<td align = \"center\">"+ eventTax +"</td>"
	    +"<td align = \"center\">"+ getEventName() +"</td>"
	    +"<td align = \"center\">"+ payment + "</td>"
	    +"<td align = \"center\">"+ myst + "</td>"    
	   	+"</tr>"+ tableEnd;
	}
}
