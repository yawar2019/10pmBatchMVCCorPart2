using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatafirstApproachExampleInCore.Models
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
        {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AnuragMotelGroup> AnuragMotelGroups { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<BankModel> BankModels { get; set; }
        public virtual DbSet<BranchTable> BranchTables { get; set; }
        public virtual DbSet<Cricket> Crickets { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DepartmentTable> DepartmentTables { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public virtual DbSet<EmployeeModelDemo> EmployeeModelDemos { get; set; }
        public virtual DbSet<Employeedet2> Employeedet2s { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<HorrorMovie> HorrorMovies { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<RegisterModel> RegisterModels { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentDetail> StudentDetails { get; set; }
        public virtual DbSet<SuryaCoModel> SuryaCoModels { get; set; }
        public virtual DbSet<TableDepartment> TableDepartments { get; set; }
        public virtual DbSet<TblCustomProperty> TblCustomProperties { get; set; }
        public virtual DbSet<TestEmployee> TestEmployees { get; set; }
        public virtual DbSet<Testview> Testviews { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=azam-pc\\sqlexpress;Initial Catalog=Employee;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountName).IsRequired();

                entity.Property(e => e.AccountType).IsRequired();
            });

            modelBuilder.Entity<AnuragMotelGroup>(entity =>
            {
                entity.Property(e => e.City).IsRequired();

                entity.Property(e => e.Location).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BankModel>(entity =>
            {
                entity.HasKey(e => e.BankId)
                    .HasName("PK_dbo.BankModels");
            });

            modelBuilder.Entity<BranchTable>(entity =>
            {
                entity.HasKey(e => e.BranchId);

                entity.ToTable("BranchTable");

                entity.Property(e => e.BranchId).ValueGeneratedNever();

                entity.Property(e => e.BranchName).HasMaxLength(50);
            });

            modelBuilder.Entity<Cricket>(entity =>
            {
                entity.Property(e => e.AgaintsTeam).IsRequired();

                entity.Property(e => e.PlayerName).IsRequired();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId);

                entity.ToTable("Customer");

                entity.Property(e => e.CustId).ValueGeneratedNever();

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustName).HasMaxLength(50);

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("Department");

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.NoOfEmployees).HasColumnName("No_of_Employees");
            });

            modelBuilder.Entity<DepartmentTable>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("DepartmentTable");

                entity.Property(e => e.DeptId).ValueGeneratedNever();

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DepartmentTables)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_DepartmentTable_BranchTable");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Designation1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Designation");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.EmpName).IsRequired();
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("employeeDetails");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobLocation).HasMaxLength(50);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobiles).HasMaxLength(50);
            });

            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_Employee");

                entity.ToTable("EmployeeInfo");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeModelDemo>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("EmployeeModelDemo");
            });

            modelBuilder.Entity<Employeedet2>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("employeedet2");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.ToTable("Gender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Gender1)
                    .HasMaxLength(50)
                    .HasColumnName("Gender");
            });

            modelBuilder.Entity<HorrorMovie>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.MovieName).IsRequired();

                entity.Property(e => e.MovieType).IsRequired();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PatientName).HasColumnName("patientName");
            });

            modelBuilder.Entity<RegisterModel>(entity =>
            {
                entity.ToTable("RegisterModel");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.Property(e => e.Sid).HasColumnName("SId");

                entity.Property(e => e.Sname).IsRequired();
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.StateName).IsRequired();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Student");

                entity.Property(e => e.StName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentDetail>(entity =>
            {
                entity.HasKey(e => e.StudId)
                    .HasName("PK_dbo.StudentDetails");
            });

            modelBuilder.Entity<SuryaCoModel>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_dbo.SuryaCoModels");
            });

            modelBuilder.Entity<TableDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tableDepartment");

                entity.Property(e => e.Department)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomProperty>(entity =>
            {
                entity.HasKey(e => e.PropertyId);

                entity.ToTable("tbl_CustomProperty");

                entity.Property(e => e.FieldType).HasMaxLength(50);

                entity.Property(e => e.PropertyName).HasMaxLength(50);

                entity.Property(e => e.PropertyValue).HasMaxLength(500);

                entity.Property(e => e.ReadOnlyProp)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestEmployee>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Salary)
                    .IsRequired()
                    .HasColumnName("salary");
            });

            modelBuilder.Entity<Testview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("testview");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.EmpId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("UserDetail");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRoleMapping>(entity =>
            {
                entity.ToTable("UserRoleMapping");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
