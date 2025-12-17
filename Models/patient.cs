using System;
using System.ComponentModel.DataAnnotations;


public class Patient
{
public int Id { get; set; }


[Required]
public string Name { get; set; }


public int Age { get; set; }


public string Gender { get; set; }


public string Disease { get; set; }
}