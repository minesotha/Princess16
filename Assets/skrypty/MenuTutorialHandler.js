function OnMouseDown()
	{
		
		if (this.name == "Tutorial btn")
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
	   Application.LoadLevel (3); 
   }
   