namespace Vibemaan.Data
{
	public class Playlist
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Composition> Tracks = new List<Composition>();
	}
}
