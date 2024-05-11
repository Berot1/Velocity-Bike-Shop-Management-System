using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velocity_Bike_Shop_Managemennt_System.Properties;

namespace Velocity_Bike_Shop_Managemennt_System.Rating
{
    public partial class UserControlRating : UserControl
    {
        public event Action<int> RatingChanged;

        public UserControlRating()
        {
            InitializeComponent();
            SetRating(0);
        }

        public int Rating { get; private set; }

        public void SetRating(int rating = 0)
        {
            // If rating is provided, set the stars accordingly
            if (rating > 0 && rating <= 5)
            {
                pbxStar1.Image = rating >= 1 ? Resources.Black_Star : Resources.Empty_Star;
                pbxStar2.Image = rating >= 2 ? Resources.Black_Star : Resources.Empty_Star;
                pbxStar3.Image = rating >= 3 ? Resources.Black_Star : Resources.Empty_Star;
                pbxStar4.Image = rating >= 4 ? Resources.Black_Star : Resources.Empty_Star;
                pbxStar5.Image = rating >= 5 ? Resources.Black_Star : Resources.Empty_Star;
                Rating = rating;
            }
            else // If rating is not provided or invalid, set all stars as empty
            {
                pbxStar1.Image = Resources.Empty_Star;
                pbxStar2.Image = Resources.Empty_Star;
                pbxStar3.Image = Resources.Empty_Star;
                pbxStar4.Image = Resources.Empty_Star;
                pbxStar5.Image = Resources.Empty_Star;
                Rating = 0;
            }
        }

        private void pbxStar5_Click(object sender, EventArgs e)
        {
            SetRating(5);
            RatingChanged?.Invoke(Rating);
        }

        private void pbxStar4_Click(object sender, EventArgs e)
        {
            SetRating(4);
            RatingChanged?.Invoke(Rating);
        }

        private void pbxStar3_Click(object sender, EventArgs e)
        {
            SetRating(3);
            RatingChanged?.Invoke(Rating);
        }

        private void pbxStar2_Click(object sender, EventArgs e)
        {
            SetRating(2);
            RatingChanged?.Invoke(Rating);
        }

        private void pbxStar1_Click(object sender, EventArgs e)
        {
            SetRating(1);
            RatingChanged?.Invoke(Rating);
        }
    }
}
