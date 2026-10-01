Họ Tên : Hoàng Kim Sang 
Lớp : D19QTANM1
Lý Thuyết - Bài Làm

Câu 1: Trình bày sự khác nhau giữa Value Types (Kiểu giá trị) và Reference Types (Kiểu tham chiếu) trong C# về cơ chế lưu trữ vùng nhớ (Stack vs Heap).
1. Value Types (Kiểu giá trị)
* *Kiểu dữ liệu:* int, float, bool, char, struct, enum...
* *Vùng nhớ lưu trữ:* Dữ liệu lưu trực tiếp trên *Stack* (khi là biến cục bộ) hoặc nội tuyến bên trong đối tượng chứa nó.
* *Cơ chế sao chép:*
*Copy-by-value* (sao chép toàn bộ giá trị). Gán b = a tạo bản sao độc lập, thay đổi một bên không làm ảnh hưởng bên kia.
* *Thu hồi bộ nhớ:* Tự động giải phóng ngay lập tức khi luồng thực thi đi ra ngoài phạm vi (scope) của hàm/block.

2. Reference Types (Kiểu tham chiếu)
* *Kiểu dữ liệu:* class, string, interface, mảng (array), delegate...
* *Vùng nhớ lưu trữ:* Đối tượng thực tế (Object data) luôn nằm trên *Heap*; biến đại diện chỉ là một con trỏ tham chiếu nằm trên *Stack* để trỏ tới vùng nhớ đó.
* *Cơ chế sao chép:*
*Copy-by-reference* (sao chép địa chỉ vùng nhớ). Gán b = a khiến cả hai cùng trỏ tới một khối dữ liệu trên Heap.
* *Thu hồi bộ nhớ:* Được quản lý tự động bởi trình gom rác *Garbage Collector (GC)* khi không còn biến tham chiếu nào trỏ tới.

Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 khác gì so với thuộc tính có set thông thường? Nêu trường hợp sử dụng thực tế.

1. Thuộc tính set thông thường
Quyền gán: Gán được khi khởi tạo và gán lại được bất kỳ lúc nào sau đó.
Hệ quả: Đối tượng có thể bị thay đổi trạng thái ở bất cứ đâu trong chương trình, khó kiểm soát và không an toàn khi dùng đa luồng.
2. Thuộc tính init (C# 9 trở lên)
Quyền gán: Chỉ gán được trong giai đoạn khởi tạo: object initializer, constructor, with expression, hoặc accessor init khác của cùng kiểu.
Bất biến sau khởi tạo: Sau khi đối tượng khởi tạo xong, mọi nỗ lực gán lại đều gây lỗi biên dịch (CS8852).
Ưu điểm so với readonly field / private set: Giữ được cú pháp object initializer gọn gàng từ bên ngoài class, mà vẫn đảm bảo tính bất biến.
Kết hợp required (C# 11): init không bắt buộc phải gán, nên thêm required để buộc người dùng gán giá trị lúc khởi tạo.

* Sử dụng thực tế :
  - DTO / Request / Response model: dữ liệu nhận từ API hay trả về chỉ nên đọc, không bị sửa lung tung.
  - Cấu hình (Options pattern): đối tượng cấu hình nạp một lần lúc khởi động, sau đó bất biến.
  - Domain model / Value object: như Money, Address, Coordinate, cần tính bất biến để an toàn khi dùng đa luồng.

Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).
* Vai trò :
  - virtual (ở lớp cha):
    - Đánh dấu rằng phương thức này được phép bị lớp con ghi đè.
    - Có thân hàm, đóng vai trò cài đặt mặc định.
    - Không bắt buộc lớp con phải override; nếu lớp con không làm gì thì dùng cài đặt của lớp cha.

  - override (ở lớp con):
    - Thực hiện việc ghi đè, cung cấp cài đặt riêng của lớp con.
    - Chỉ dùng được khi lớp cha khai báo phương thức đó là virtual, abstract hoặc override.


Câu 4: Tại sao một thành phần được khai báo là static trong Lớp (Class) lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new?
1. Khác biệt về cấp độ sở hữu bộ nhớ
- Cấp độ Kiểu dữ liệu (Type / Class level): Thành phần static thuộc sở hữu chung của toàn bộ lớp, được nạp và khởi tạo một lần duy nhất vào bộ nhớ khi kiểu dữ liệu đó được tải, dùng chung cho toàn bộ chương trình.
- Cấp độ Đối tượng (Object level): Một thể hiện tạo bằng toán tử new chỉ quản lý vùng nhớ và trạng thái dữ liệu độc lập của riêng cá thể đối tượng đó trên vùng nhớ Heap.
2. Định hướng thiết kế ngôn ngữ của C#
- Tránh nhầm lẫn ngữ nghĩa: Trình biên dịch cấm truy xuất qua thể hiện (như instance.StaticMember) để lập trình viên không ngộ nhận rằng giá trị của thành phần đó phụ thuộc hoặc thay đổi riêng biệt theo từng đối tượng.
- Đảm bảo tính tường minh của mã nguồn (Code Clarity): Phân định rạch ròi ngay tại cú pháp gọi hàm giữa hành vi toàn cục thuộc về hệ thống (như Math.Sqrt(), DateTime.Now) và hành vi xử lý dữ liệu nội bộ của một đối tượng cụ thể.
