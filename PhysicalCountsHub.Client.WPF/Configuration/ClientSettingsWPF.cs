using PocketHub.Client.Lib.Configuration;

namespace PhysicalCountsHub.Client.WPF.Configuration
{
    public class ClientSettingsWPF : ClientSettings
    {
        public string   R2BaseURL               { get; set; }
        public string   R2Username              { get; set; }
        public string   R2Password              { get; set; }
        public string   R2CertificateThumb      { get; set; }
        public int      R2CheckIntervalSeconds  { get; set; }


        public static ClientSettingsWPF CreateDraft()
            => new ClientSettingsWPF
            {

            };
    }
}
