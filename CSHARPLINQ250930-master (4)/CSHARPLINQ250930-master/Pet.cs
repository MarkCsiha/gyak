class Pet
{
    public string? Name { get; set; }
    public string? Species { get; set; }
    public string? Breed { get; set; }
    public DateTime Born { get; set; }
    public bool IsAlive { get; set; }
    public float Age => (float)Math.Round(
        (decimal)(DateTime.Now - Born).TotalDays / 365, 2);
    public int Legs { get; set; }
    public string? Owner { get; set; }

    public override string ToString() =>
        $"\n\tName: {Name} {(IsAlive ? "" : "(\u271D)")}\n" +
        $"\tOwner: {Owner}\n" +
        $"\tRace: {Species} ({Breed})\n" +
        $"\tAge: {Age} yrs old\n";
}
