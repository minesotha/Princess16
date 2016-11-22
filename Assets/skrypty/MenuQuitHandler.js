
	function OnMouseDown()
	{
		
		if (this.name == "Quit btn")
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
	   Application.Quit();
   }
   