using System.Xml;
using System.Xml.Serialization;

[XmlRoot("MapContainer")]
public class _MapContainer {

	[XmlElement("Map")]
	public _Map map;

	public _MapContainer()
	{
		map = new _Map ();
	}

	public _MapContainer(_Map map)
	{
		this.map = map;
	}
}