using UnityEngine;
using System.Collections;

/// <summary>
/// Base class for all View related classes.
/// </summary>
public class View : Element
{
	public PlayerView player { get { return m_player = Assert<PlayerView>(m_player); } }
	private PlayerView m_player;

	public BalloonView balloon { get { return m_balloon = Assert<BalloonView>(m_balloon); } }
	private BalloonView m_balloon;


}

/// <summary>
/// Base class for all View related classes.
/// </summary>
public class View<T> : View where T : BaseApplication
{
	/// <summary>
	/// Returns app as a custom 'T' type.
	/// </summary>
	new public T app { get { return (T)base.app; } }
}
