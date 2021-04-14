/* Tổng kết thay đổi */
//Database
	//9/4/2021
	Tạm thời loại bỏ 1 số bảng chưa cần thiết.
	Execute từng cụm lệnh, proc nào báo lỗi thì bỏ qua.
	//14/4/2021
	Thêm các bảng liên quan đến "Dịch vụ" 
	
//Application
	//9/4/2021
	Tạm thời loại bỏ tab "Thống kê" và "Hóa đơn"
	Thay đổi tab "Phòng trọ":
		- Thêm phần textbox hiển thị yêu cầu dịch vụ (GhiChu - CT_KHACH_THUE)
		- Thêm chức năng checkout/ xóa khách khỏi phòng (Chưa hoàn thiện)
			+ Khi sai sót trong quá trình đăng ký: Chọn phòng -> Chọn khách -> xóa khách bởi MaKhach khỏi CT_KHACH_THUE
			+ Khi khách trả phòng: Chọn phòng -> Chuyển đến giao diện thanh toán (chưa thiết kế)
	Thay đổi tab "Bảng giá phòng":
		Hiển thị bảng GIA_THUE: giá phòng tham khảo.
		Bỏ chức năng thay đổi giá phòng trực tiếp trên app.
		Hiển thị giá danh sách dịch vụ (chưa thiết kế _ tương tự như giá thuê)
	//11/4/2021
	Thêm form "SelectInfo" để chọn thông tin hiển thị cho client, xác thực bởi số người trong phòng.
	Chỉnh sửa form "GuestRoom".
	//14/4/2021
	Thao tác cho chức năng đặt dịch vụ của client.
	