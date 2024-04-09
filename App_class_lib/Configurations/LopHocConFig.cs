using App_class_lib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_class_lib.Configurations
{
	public class LopHocConFig : IEntityTypeConfiguration<LopHoc>
	{
		public void Configure(EntityTypeBuilder<LopHoc> builder)
		{
			builder.ToTable("LopHoc");
			builder.HasKey(p=>p.MaLop);
			builder.HasMany(p => p.SinhViens).WithOne(p => p.lopHocs).HasForeignKey(p => p.MaLop);
			builder.Property(p => p.TenLop).HasColumnType("nvarchar(max)");
			builder.Property(p => p.Khoa).HasColumnType("int");
		}
	}
}
