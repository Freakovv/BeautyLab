using System;
using System.IO;
using System.Xml.Serialization;

public class AppConfig : IDisposable
{
    private static readonly string ConfigFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appConfig.xml");

    public int Volume { get; set; } = 5;
    private int _cornerRadius = 10;
    private bool _disposed = false;

    public int CornerRadius { get; set; }

    public void Load()
    {
        if (File.Exists(ConfigFilePath))
        {
            using FileStream fs = new FileStream(ConfigFilePath, FileMode.Open);
            var loadedConfig = (AppConfig)new XmlSerializer(typeof(AppConfig)).Deserialize(fs);
            Volume = loadedConfig.Volume;
            CornerRadius = loadedConfig.CornerRadius;
        }
        else
        {
            SetDefaultConfig();
            Save();
        }
    }

    private void SetDefaultConfig()
    {
        Volume = 5;
        CornerRadius = 10;
    }

    public void Save()
    {
        using FileStream fs = new FileStream(ConfigFilePath, FileMode.Create);
        new XmlSerializer(typeof(AppConfig)).Serialize(fs, this);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            _disposed = true;
        }
    }

    ~AppConfig()
    {
        Dispose(false);
    }
}