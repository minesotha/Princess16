function OnMouseDown()
	{
		
		if (this.name == "Start btn")
	   {
	     StartLevel();
	   }
	   
	}
   
   function StartLevel ()
	{
		GetComponent.<AudioSource>().Play();             
		while (GetComponent.<AudioSource>().isPlaying) 
		   {
		      yield;
		   }
	   Application.LoadLevel (4); 
   }
   