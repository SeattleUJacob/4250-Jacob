using System;
using SQLite;

namespace Mine.Models
{
    /// <summary>
    /// Items for the characters and monsters to use
    /// </summary>
    public class ItemModel
    {
        // The Id for the items
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // The display text for the item
        public string Text { get; set; }

        // The description for the item
        public string Description { get; set; }

        // The Value of the Item +9 damage
        public int Value { get; set; } = 0;
    }
}