using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KeyToSaftey.DBModels
{
    public partial class KeyToSafteyContext : DbContext
    {
        public KeyToSafteyContext()
        {
        }

        public KeyToSafteyContext(DbContextOptions<KeyToSafteyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addtocart> Addtocarts { get; set; }
        public virtual DbSet<AdminSignup> AdminSignups { get; set; }
        public virtual DbSet<BillingAdd> BillingAdds { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Ordermaster> Ordermasters { get; set; }
        public virtual DbSet<Pinfo> Pinfos { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Signup> Signups { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=KeyToSaftey;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Addtocart>(entity =>
            {
                entity.ToTable("Addtocart");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Pid).HasColumnName("PId");

                entity.Property(e => e.Pname).IsUnicode(false);

                entity.Property(e => e.Pprice).HasColumnName("PPrice");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AdminSignup>(entity =>
            {
                entity.ToTable("AdminSignup");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aemail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AEmail");

                entity.Property(e => e.AfullName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("AFullName");

                entity.Property(e => e.Amobile)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("AMobile");

                entity.Property(e => e.Apassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APassword");
            });

            modelBuilder.Entity<BillingAdd>(entity =>
            {
                entity.ToTable("BillingAdd");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Addressline01)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("addressline01");

                entity.Property(e => e.Addressline02)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("addressline02");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("district");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname ");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastname ");

                entity.Property(e => e.Mobile)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("mobile");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Pincode)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pincode");

                entity.Property(e => e.UserMobile)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("userMobile");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__tmp_ms_x__C6DE0CC13C835DE7");

                entity.ToTable("Blog");

                entity.Property(e => e.Bid).HasColumnName("BId");

                entity.Property(e => e.Bauthor)
                    .IsUnicode(false)
                    .HasColumnName("BAuthor");

                entity.Property(e => e.Bdetails)
                    .IsUnicode(false)
                    .HasColumnName("BDetails");

                entity.Property(e => e.Bimage).HasColumnName("BImage");

                entity.Property(e => e.Bname)
                    .IsUnicode(false)
                    .HasColumnName("BName");

                entity.Property(e => e.Bpara)
                    .IsUnicode(false)
                    .HasColumnName("BPara");

                entity.Property(e => e.Bstatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BStatus");

                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fname ");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("mobile")
                    .IsFixedLength(true);

                entity.Property(e => e.Text)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("text");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Image1).HasColumnName("Image");
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.ToTable("Orderdetails\r\n");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Mobile)
                    .HasMaxLength(10)
                    .HasColumnName("Mobile ")
                    .IsFixedLength(true);

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.Pid)
                    .HasMaxLength(10)
                    .HasColumnName("PId")
                    .IsFixedLength(true);

                entity.Property(e => e.Pname)
                    .HasMaxLength(10)
                    .HasColumnName("Pname ")
                    .IsFixedLength(true);

                entity.Property(e => e.Price)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Quantity)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Ordermaster>(entity =>
            {
                entity.HasKey(e => e.Orderid);

                entity.ToTable("Ordermaster");

                entity.Property(e => e.Orderid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("orderid");

                entity.Property(e => e.Addressline01)
                    .IsUnicode(false)
                    .HasColumnName("addressline01");

                entity.Property(e => e.Adressline02)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("adressline02");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("firstname ");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(10)
                    .HasColumnName("lastname ")
                    .IsFixedLength(true);

                entity.Property(e => e.Mobile)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("mobile ");

                entity.Property(e => e.Pincode)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("pincode");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userMobile");
            });

            modelBuilder.Entity<Pinfo>(entity =>
            {
                entity.ToTable("Pinfo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Img)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Link)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.Rating)
                    .IsUnicode(false)
                    .HasColumnName("rating");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__tmp_ms_x__C5775540915894D9");

                entity.ToTable("Product");

                entity.Property(e => e.Pid)
                    .ValueGeneratedNever()
                    .HasColumnName("PId");

                entity.Property(e => e.Catagory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdes)
                    .IsUnicode(false)
                    .HasColumnName("PDes");

                entity.Property(e => e.Pimg).HasColumnName("PImg");

                entity.Property(e => e.Pname)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.Pprice).HasColumnName("PPrice");
            });

            modelBuilder.Entity<Signup>(entity =>
            {
                entity.HasKey(e => e.Mobile)
                    .HasName("PK__tmp_ms_x__6FAE0783F95B55DB");

                entity.ToTable("Signup");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.ToTable("Table");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Img)
                    .IsUnicode(false)
                    .HasColumnName("img");

                entity.Property(e => e.Link)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Rating)
                    .IsUnicode(false)
                    .HasColumnName("rating");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
