using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_class_lib.Models
{
	public class SinhVien
	{
		public Guid Id { get; set; }
		public string Ten { get; set; }
		public int Tuoi { get; set; }
		public string Nganh { get; set; }
		public string MaLop { get; set; }	
		public virtual LopHoc lopHocs { get; set; }
	}
}
