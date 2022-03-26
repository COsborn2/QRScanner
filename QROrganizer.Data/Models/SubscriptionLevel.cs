using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QROrganizer.Data.Models;

public class SubscriptionLevel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string SubscriptionName { get; set; }

    public ICollection<SubscriptionFeature> Features { get; set; }
}
