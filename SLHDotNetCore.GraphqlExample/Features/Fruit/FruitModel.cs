using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLHDotNetCore.GraphqlExample.Features.Fruit;

[Table("Tbl_Fruit")]
public class FruitModel
{
    [Key]
    public int Fruit_Id { get; set; }
    public string Fruit_Name { get; set; }
}
