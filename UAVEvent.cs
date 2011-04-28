public class UAVEvent
{
   private UAVCommand commmand;
   public Command
   {
      get { return command;}
   }
   
   private int value;
   public int Value
   {
      get { return value; }
   }
   
   public UAVEvent(Commmand command, int value)
   {
      this.command = commmand;
	  this.value = value;
   }  
}

public class UAVHeartBeat : UAVEvent
{
   public UAVHeartBeat(int value)
   {
      base(Command.UAVHeartBeat,value);
   }
}

public class Unknown : UAVEvent
{
   public UnknownUAVEvent(int value)
   {

       base(Command.Unknown, value);    
   }
}

public class UAVEventFactory()
{
   public UAVEvent create(Command command,int value)
   {
      switch(command)
	  {
	     UAVEHeartBeat:
			return new UAVHeartBeat(value);
			break;
	     default:
		    return new UnknownUAVEVent(value);
			break;
	  }
   }
}

public class UAVEventProcessor
{
   Map listeners;
   List events;
   UAVEventFactory eventFactory;
   
   public void listenForEvent(Command command, Method method)
   {
      if(map.contains(command))
	  {
	     map.get(command).put(method);
	  }
	  else
	  {
	     map.put(new list().add(method));
	  }
   }
   
   public void addEvent(Command commmand, int value)
   {
      addEvent(eventFactory.create(command,value));
   }
   
   public void addEvent(UAVEvent event)
   {
      events.add(event);
   }
   
   public void processEvent()
   {
     forEach(UAVEvent event in events)
	 {
	    if(map.contains(event.command))
		{
		   forEach(Method listner in map.get(event.Command)))
		   {
		      listner(value);
		   }
		}
	 }
   }
   
   
}