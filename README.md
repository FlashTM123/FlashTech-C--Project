# FlashTech ⚡

Hệ thống quản lý bán laptop xây dựng bằng **Blazor Web App** với giao diện hiện đại sử dụng **Tailwind CSS**.

## 🚀 Công nghệ sử dụng

- **Framework**: .NET 10.0 / Blazor Server
- **Database**: MySQL
- **ORM**: Entity Framework Core 8.0.2 + Pomelo.EntityFrameworkCore.MySql
- **UI**: Tailwind CSS (CDN)
- **IDE**: Visual Studio Code

## 📁 Cấu trúc dự án

```
FlashTech/
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor      # Layout chính
│   │   ├── NavMenu.razor         # Menu điều hướng
│   │   └── ReconnectModal.razor  # Modal reconnect
│   └── Pages/
│       ├── Home.razor            # Trang chủ
│       ├── Counter.razor         # Bộ đếm
│       ├── Weather.razor         # Thời tiết
│       ├── Brands/
│       │   ├── Brands.razor      # Quản lý thương hiệu
│       │   ├── Create.razor      # Thêm thương hiệu
│       │   └── Edit.razor        # Sửa thương hiệu
│       └── Users/
│           └── Users.razor       # Quản lý người dùng
├── Data/
│   └── AppDBContent.cs           # Database Context
├── Models/
│   ├── Brands.cs                 # Model thương hiệu
│   └── Users.cs                  # Model người dùng
├── Service/
│   ├── Brands/
│   │   ├── BrandService.cs       # Service thương hiệu
│   │   └── IBrandService.cs      # Interface service thương hiệu
│   ├── IUserService.cs           # Interface service user
│   └── UserService.cs            # User service
├── wwwroot/
│   └── app.css                   # CSS tùy chỉnh
├── Program.cs                    # Entry point
├── appsettings.json              # Cấu hình
└── FlashTech.csproj              # Project file
```

## ⚙️ Cài đặt

### 1. Yêu cầu
- .NET 10.0 SDK
- MySQL Server
- Visual Studio Code

### 2. Cấu hình Database

Tạo database MySQL và cập nhật connection string trong `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=your_database;user=root;password=your_password"
  }
}
```

### 3. Tạo bảng Users và Brands trong MySQL

```sql
CREATE TABLE users (
  Id INT PRIMARY KEY AUTO_INCREMENT,
  userName VARCHAR(100),
  password VARCHAR(255),
  email VARCHAR(100),
  address VARCHAR(255),
  role VARCHAR(50)
);

CREATE TABLE brands (
  Id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(100) NOT NULL
);
```

### 4. Chạy ứng dụng

```bash
cd FlashTech
dotnet restore
dotnet build
dotnet run
```

Truy cập: `http://localhost:5254`

## 📸 Tính năng


### Quản lý thương hiệu (`/brands`)
- ✅ Hiển thị danh sách thương hiệu
- ✅ Thêm thương hiệu mới (`/brands/create`)
- ✅ Sửa thương hiệu (`/brands/edit/{id}`)
- ✅ Xóa thương hiệu (cập nhật UI ngay sau khi xóa)
- ✅ Loading state, empty state

### Quản lý người dùng (`/users`)
- ✅ Hiển thị danh sách người dùng
- ✅ Tìm kiếm người dùng
- ✅ Lọc theo vai trò (Admin, Moderator, Employee)
- ✅ Badge màu theo vai trò
- ✅ Thêm người dùng mới (`/users/create`)
- 🔲 Sửa thông tin người dùng
- 🔲 Xóa người dùng

### Giao diện
- ✅ Sidebar navigation với gradient
- ✅ Responsive design
- ✅ Loading state với spinner
- ✅ Empty state khi không có dữ liệu

## 🎨 UI/UX

Giao diện sử dụng Tailwind CSS với bảng màu:
- **Primary**: Indigo (#4F46E5) → Purple (#7C3AED)
- **Sidebar**: Slate-800 (#1e293b)
- **Background**: Gray-50 (#f9fafb)

## 📦 Dependencies

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.2" />
<PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.2" />
```

## 👤 Tác giả

**FlashTech Team**

## 📝 License

MIT License
