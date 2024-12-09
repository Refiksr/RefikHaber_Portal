﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

public class HaberTuru
{
    [Key]  // primary key
    public int Id { get; set; }
    [Required(ErrorMessage = "Kategori Adı Boş Bırakılamaz!")] //not null
    [MaxLength(25)]
    [DisplayName("Kategori Adı")]
    public string Ad { get; set; }
}
