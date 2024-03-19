using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Keyless]
[Table("NHANVIEN")]
public partial class Nhanvien
{
    [Column("HOTEN")]
    [StringLength(50)]
    public string? Hoten { get; set; }

    [Column("MANV")]
    [StringLength(7)]
    public string? Manv { get; set; }

    [Column("NGSINH", TypeName = "date")]
    public DateTime? Ngsinh { get; set; }

    [Column("DCHI")]
    [StringLength(30)]
    public string? Dchi { get; set; }

    [Column("PHAI")]
    public bool? Phai { get; set; }

    [Column("LUONG")]
    public double? Luong { get; set; }
}
