namespace YouTube
{
    public static class ExtensionMetodsKanal
    {
        public static string Serialize(this Kanal kanal)
        {
            return $"Ilsoc subów : {kanal.IloscSubskrypcji}, Id Kanalu: {kanal.Id}, Ilosc wyswietlen wszyskich filmów: {kanal.LicznikWyswietlen}";
        }
    }
}