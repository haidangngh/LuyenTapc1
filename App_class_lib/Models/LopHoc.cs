using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_class_lib.Models
{
	public class LopHoc
	{
		public string MaLop { get; set; }
		public string TenLop { get; set; }
		public int Khoa { get; set; }
		public virtual ICollection<SinhVien> SinhViens { get; set; }
	}
}
