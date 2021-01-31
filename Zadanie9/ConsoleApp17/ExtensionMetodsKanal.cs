namespace YouTube
{
    public static class ExtensionMetodsKanal
    {
        public static string Serialize(this Kanal kanal)
        {
            return $"Ilosc subow: {kanal.IloscSubow} na kanale: {kanal.Name}, " +
                   $"Id Kanalu: {kanal.Id} Ilosc wyswietlen: {kanal.LicznikWyswietlen}";
        }
    }
}