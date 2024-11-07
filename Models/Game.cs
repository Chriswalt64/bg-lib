using System.ComponentModel.DataAnnotations;

namespace bg_lib.Models;

public class Game 
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set;}
    public int IsPlayToWin { get; set; }
    public int IsInCirculation { get; set; }
    public int IsCheckedOut { get; set; }
    public DateTime? LastCheckoutDate { get; set; }
    public DateTime? LastCheckinDate { get; set; }
}