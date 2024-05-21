using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

[ComplexType]
public record Price
(
    decimal value = 0,
    string currency = "BRL"
);
