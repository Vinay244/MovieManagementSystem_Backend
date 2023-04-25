using MovieActorAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MovieActorMVC.Models
{
    public class Movie
    {
            public int Id { get; set; }

            public string Title { get; set; }

           
            public int ReleaseYear { get; set; }
            public string Genre { get; set; }


            public int? ActorID { get; set; }
            [ForeignKey("ActorID")]
            public virtual Actor? Actor { get; set; }

		    public int? DirectorID { get; set; }
            [ForeignKey("DirectorID")]    
		    public virtual Director? Director { get; set; }
	}
}

