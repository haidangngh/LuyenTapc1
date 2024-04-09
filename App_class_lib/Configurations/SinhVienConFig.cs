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
	internal class SinhVienConFig : IEntityTypeConfiguration<SinhVien>
	{
		public void Configure(EntityTypeBuilder<SinhVien> builder)
		{
			builder.ToTable("SinhVien");
			builder.HasKey(p=>p.Id);
			builder.Property(p => p.Ten).HasColumnType("nvarchar(max)");
			builder.Property(p => p.Tuoi).HasColumnType("int");
			builder.Property(p => p.Nganh).HasColumnType("nvarchar(max)");
			builder.Property(p => p.MaLop).HasColumnType("nvarchar(max)");
		}
	}
}
