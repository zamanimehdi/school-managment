namespace Internet_SM.Properties
{
       
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        public Settings()
        {
            this.PropertyChanged +=
              new System.ComponentModel.PropertyChangedEventHandler(this.Settings_PropertyChanged);
        }
        private void Settings_PropertyChanged(System.Object sender,
                 System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "conect2server")
            {
                this["SMConnectionString"] = this.conect2server;
            }
            if (e.PropertyName == "conect2local")
            {
                this["fajrConnectionString"] = this.conect2local;
            }
        }


    }
}
