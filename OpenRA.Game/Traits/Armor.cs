#region Copyright & License Information
/*
 * Copyright 2007-2014 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

namespace OpenRA.Traits
{
	[Desc("Used to define weapon efficiency modifiers with different percentages per Type.")]
	public class ArmorInfo : TraitInfo<Armor>
	{
		public readonly string Type = null;
	}

	public class Armor { }
}