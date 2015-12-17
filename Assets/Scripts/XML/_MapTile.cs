using System.Xml;
using System.Xml.Serialization;

public class _MapTile {

	[XmlAttribute("objectName")]
	public string tileObjectName { get; set; }

	public _MapTile() : this("") {}

	public _MapTile(string tileObjectName)
	{
		this.tileObjectName = tileObjectName;
	}
}