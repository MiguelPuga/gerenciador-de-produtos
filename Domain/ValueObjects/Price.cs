namespace Domain;

public record Price
(
    float value,
    string currency = "BRL"
);
