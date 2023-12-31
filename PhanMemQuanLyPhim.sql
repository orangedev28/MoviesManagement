USE [PhanMemQuanLyPhim]
GO
/****** Object:  Table [dbo].[DaoDien]    Script Date: 10/20/2022 10:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaoDien](
	[MaDaoDien] [nvarchar](20) NOT NULL,
	[TenDaoDien] [nvarchar](200) NOT NULL,
	[ThongTinDaoDien] [nvarchar](max) NULL,
 CONSTRAINT [PK_DaoDien] PRIMARY KEY CLUSTERED 
(
	[MaDaoDien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DienVien]    Script Date: 10/20/2022 10:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienVien](
	[MaDienVien] [nvarchar](20) NOT NULL,
	[TenDienVien] [nvarchar](200) NOT NULL,
	[ThongTinDienVien] [nvarchar](max) NULL,
 CONSTRAINT [PK_DienVien] PRIMARY KEY CLUSTERED 
(
	[MaDienVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 10/20/2022 10:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MaNhaSX] [nvarchar](20) NOT NULL,
	[TenNhaSX] [nvarchar](200) NOT NULL,
	[ThongTinNhaSX] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNhaSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NuocSanXuat]    Script Date: 10/20/2022 10:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NuocSanXuat](
	[MaNuocSX] [nvarchar](20) NOT NULL,
	[TenNuocSX] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_NuocSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNuocSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phim]    Script Date: 10/20/2022 10:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phim](
	[MaPhim] [nvarchar](20) NOT NULL,
	[TenPhim] [nvarchar](max) NOT NULL,
	[ThoiLuong] [nvarchar](20) NOT NULL,
	[GioiHanTuoi] [nvarchar](50) NOT NULL,
	[NoiDungChinh] [nvarchar](max) NOT NULL,
	[MaTheLoai] [nvarchar](20) NOT NULL,
	[MaDienVien] [nvarchar](20) NOT NULL,
	[MaDaoDien] [nvarchar](20) NOT NULL,
	[MaNhaSX] [nvarchar](20) NOT NULL,
	[MaNuocSX] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Phim] PRIMARY KEY CLUSTERED 
(
	[MaPhim] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 10/20/2022 10:30:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [nvarchar](20) NOT NULL,
	[TenTheLoai] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'1', N'James Wan', N'Ôn Tử Nhân, hay còn được biết đến với nghệ danh James Wan, là một nam đạo diễn, nhà biên kịch kiêm nhà sản xuất điện ảnh người Úc gốc Malaysia.')
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'2', N'Jaume Collet-Serra', N'Jaume Collet-Serra là đạo diễn và nhà sản xuất phim người Mỹ gốc Tây Ban Nha. Ông đã đạo diễn các bộ phim kinh dị House of Wax, Orphan và The Shallows, cũng như các bộ phim kinh dị do Liam Neeson dẫn dắt là Unknown, Non-Stop, Run All Night và The Commuter.')
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'3', N'Roland Emmerich', N'Roland Emmerich là một đạo diễn, biên kịch và nhà sản xuất phim người Đức, các tác phẩm điện ảnh của ông chủ yếu thuộc thể loại thảm họa và hành động. Những bộ phim do ông đạo diễn đã đạt tổng doanh thu trên 3 tỷ USD trên toàn thế giới, nhiều hơn so với bất cứ một đạo diễn châu Âu nào.')
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'4', N'Chad Stahelski', N'Chad Stahelski là một diễn viên đóng thế và đạo diễn phim người Mỹ. Ông được biết đến với việc đạo diễn bộ phim John Wick năm 2014 và đạo diễn ba phần tiếp theo của nó. Stahelski cũng nhân đôi cho Brandon Lee sau tai nạn chết người liên quan đến Lee trên phim trường The Crow và thay thế Lee trong phim.')
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'5', N'James Cameron', N'James Francis Cameron CC là một nhà làm phim kiêm nhà hoạt động môi trường người Canada hiện đang sống tại New Zealand. Ông nổi tiếng với việc thực hiện các phim điện ảnh khoa học viễn tưởng và sử thi.')
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'6', N'Ha Byung-hoon', N'Chưa cập nhật thông tin')
INSERT [dbo].[DaoDien] ([MaDaoDien], [TenDaoDien], [ThongTinDaoDien]) VALUES (N'7', N'Victor Fleming', N'Victor Lonzo Fleming là một đạo diễn, nhà quay phim và nhà sản xuất phim người Mỹ. Các bộ phim nổi tiếng nhất của ông là Cuốn theo chiều gió, bộ phim mà ông đã giành được Giải thưởng Viện hàn lâm cho Đạo diễn xuất sắc nhất và The Wizard of Oz.')
GO
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'1', N'Dwayne Johnson', N'Dwayne Johnson tên đầy đủ là Dwayne Douglas Johnson, còn được biết đến với nghệ danh là The Rock là một đô vật chuyên nghiệp đã nghỉ hưu, diễn viên và nhà sản xuất người Mỹ.')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'2', N'Patrick Wilson', N'Patrick Joseph Wilson là một diễn viên và ca sĩ người Mỹ. Anh đã dành sự nghiệp đầu tiên của mình với sự tham gia của các vở nhạc kịch Broadway, bắt đầu từ năm 1995. Anh là ứng cử viên giải Tony hai lần cho vai diễn của anh trong Full Monty và Oklahoma!.')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'3', N'Keanu Reeves', N'Keanu Charles Reeves, là một diễn viên, đạo diễn, nhà sản xuất và nhạc sĩ người Canada.')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'4', N'Jason Momoa', N'Joseph Jason Namakaeha Momoa là nam diễn viên, đạo diễn và nhà sản xuất phim người Mỹ. Jason Momoa nổi tiếng với các vai diễn siêu anh hùng trong vũ trụ DC Mở rộng DC Extended Universe, bắt đầu từ năm 2016 với vai thủy thần Aquaman trong Batman v Superman: Dawn of Justice, Justice League và Aquaman.')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'5', N'Sam Worthington', N'Samuel Henry J. "Sam" Worthington là một diễn viên người Úc. Anh được biết đến với vai Jake Sully trong Avatar và phần tiếp theo sắp tới Avatar 2, Marcus Wright trong Terminator Salvation, và Perseus trong Clash of the Titans và phần tiếp theo của nó là Wrath of the Titans.')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'6', N'Lee Do Hyun', N'Lee Do-hyun, sinh ngày 11 tháng 04 năm 1995, tên thật là Lim Dong-hyun, là nam diễn viên Hàn Quốc. Bắt đầu sự nghiệp vào năm 2017 với vai Lee Joon-ho. Đến nay, một số vai diễn nổi tiếng của anh là Go Cheong-myeong trong Hotel del Luna, Hong Dae-young trong 18 Again, Lee Eun-hyuk trong Sweet Home, Hwang Hee-tae.')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'7', N'Vivien Leigh', N'Vivien Leigh, Phu nhân Olivier, là một diễn viên điện ảnh người Anh. Bà đã giành được 2 giải Oscar ở hạng mục "Nữ diễn viên chính xuất sắc nhất" nhờ vai diễn người đẹp miền Nam: Scarlett O''Hara trong Cuốn theo chiều gió và Blanche DuBois trong Chuyến tàu mang tên dục vọng, vai này bà cũng diễn trên sân khấu West End, ...')
INSERT [dbo].[DienVien] ([MaDienVien], [TenDienVien], [ThongTinDienVien]) VALUES (N'8', N'Leonardo DiCaprio', N'Leonardo Wilhelm DiCaprio là một diễn viên, nhà sản xuất phim, nhà hoạt động môi trường người Mỹ.')
GO
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'1', N'Roland Emmerich', N'Roland Emmerich là một đạo diễn, biên kịch và nhà sản xuất phim người Đức, các tác phẩm điện ảnh của ông chủ yếu thuộc thể loại thảm họa và hành động. Những bộ phim do ông đạo diễn đã đạt tổng doanh thu trên 3 tỷ USD trên toàn thế giới, nhiều hơn so với bất cứ một đạo diễn châu Âu nào. ')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'2', N'Jon Landau', N'Jon Landau là một nam doanh nhân kiêm nhà sản xuất điện ảnh người Mỹ gốc Do Thái.')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'3', N'Chad Stahelski', N'Chad Stahelski là một diễn viên đóng thế và đạo diễn phim người Mỹ. Ông được biết đến với việc đạo diễn bộ phim John Wick năm 2014 và đạo diễn ba phần tiếp theo của nó. Stahelski cũng nhân đôi cho Brandon Lee sau tai nạn chết người liên quan đến Lee trên phim trường The Crow và thay thế Lee trong phim.')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'4', N'Dany Garcia', N'Dany Garcia là nữ doanh nhân người Mỹ, nhà sản xuất, vận động viên thể hình chuyên nghiệp IFBB.')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'5', N'Peter Safran', N'Peter Safran là một nhà sản xuất và quản lý phim người Mỹ gốc Anh.')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'6', N'JTBC Studios', N'JTBC (tiếng Hàn: 제이티비씨) là hệ thống mạng truyền hình cáp quốc gia Hàn Quốc nói chung và là công ty phát thanh truyền hình nói riêng.')
INSERT [dbo].[NhaSanXuat] ([MaNhaSX], [TenNhaSX], [ThongTinNhaSX]) VALUES (N'7', N'David O. Selznick', N'David O. Selznick là nhà sản xuất phim, nhà biên kịch và nhà điều hành hãng phim người Mỹ. Ông nổi tiếng với việc sản xuất các phim Cuốn theo chiều gió và Rebecca, mỗi phim đem lại cho ông một giải Oscar cho phim hay nhất.')
GO
INSERT [dbo].[NuocSanXuat] ([MaNuocSX], [TenNuocSX]) VALUES (N'1', N'Mỹ')
INSERT [dbo].[NuocSanXuat] ([MaNuocSX], [TenNuocSX]) VALUES (N'2', N'Anh')
INSERT [dbo].[NuocSanXuat] ([MaNuocSX], [TenNuocSX]) VALUES (N'3', N'Hàn Quốc')
INSERT [dbo].[NuocSanXuat] ([MaNuocSX], [TenNuocSX]) VALUES (N'4', N'Việt Nam')
INSERT [dbo].[NuocSanXuat] ([MaNuocSX], [TenNuocSX]) VALUES (N'5', N'Nhật Bản')
INSERT [dbo].[NuocSanXuat] ([MaNuocSX], [TenNuocSX]) VALUES (N'6', N'Hồng Kông')
GO
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P01', N'Black Adam', N'120p', N'C13', N'Gần 5.000 năm sau khi bị cầm tù với quyền năng tối thượng từ những vị thần cổ đại, Black Adam (Dwayne Johnson) sẽ được giải phóng khỏi nấm mồ chết chóc của mình, mang tới thế giới hiện đại một kiểu nhận thức về công lý hoàn toàn mới.', N'3', N'1', N'2', N'4', N'1')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P02', N'Moon Fall', N'130p', N'C13', N'Năm 2011, một tai nạn ngoài vũ trụ khiến một phi hành gia tử vong đầy bí ẩn. Đúng 10 năm sau, Mặt Trăng đột nhiên rời khỏi quỹ đạo và dần trên đường va chạm với Trái Đất. Chuyện dường như có liên quan tới tai nạn năm xưa, và chỉ có những đồng đội của phi hành gia xấu số kia mới có thể tìm ra chân tướng sự việc, cũng như bản chất của Mặt Trăng sau hàng tỷ năm bị giấu kín.', N'1', N'2', N'3', N'1', N'1')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P03', N'John Wick: Chapter 4', N'130p', N'C18', N'Với cái giá phải trả ngày càng tăng, John Wick tham gia cuộc chiến chống lại High Table trên toàn cầu khi tìm kiếm những người chơi quyền lực nhất trong thế giới ngầm, từ New York qua Paris, Osaka đến cả Berlin.', N'1', N'3', N'4', N'3', N'1')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P04', N'Trở lại tuổi 18 - Eighteen Again', N'60p một tập', N'C16', N'Trở lại tuổi 18 - Eighteen Again (2020) là webdrama thứ 3 của jTBC trong tháng 9 này và đồng thời cũng là bộ phim thứ 3 lấy đề tài xuyên không. Phim kể về người đàn ông 33 tuổi Hong Dae Young (Yoon Sang Hyun thủ vai) năm 18 tuổi anh từng là một tuyển thủ bóng rổ triển vọng nhưng đã giã từ sự nghiệp để vun đắp cuộc sống cùng bạn gái đã mang thai. 
Hiện tại anh chỉ là một người thất nghiệp, đang bị vợ đòi ly hôn và bị con cái xa lánh. Sau một tai nạn, Dae Young trở về hình dáng năm 18 tuổi và đổi tên thành Go Woo Young (Lee Do Hyun) để bắt đầu một cuộc đời mới...', N'4', N'6', N'6', N'6', N'3')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P05', N'Avatar', N'120p', N'C13', N'Đây là câu chuyện về gia đình Sully và những gì họ làm để giữ cho gia đình luôn được ở cạnh nhau. Jake và Neytiri sẽ có gia đình riêng trong phần này, họ buộc phải rời khỏi nhà để ra ngoài khám phá những vùng khác nhau ở Pandora và dành phần lớn thời gian ở dưới nước. Tôi nghĩ đến việc tại sao bây giờ mọi người lại quan tâm đến giải trí nhiều hơn bao giờ hết? Tôi nghĩ rằng đó là cách để họ trốn thoát khỏi thế giới chúng ta đang ở, để thoát khỏi những áp lực khác mà họ gặp trong cuộc sống. Tôi nghĩ với Avatar, chúng ta có cơ hội cho phép mọi người trốn thoát đến một thế giới đáng kinh ngạc với những nhân vật đáng kinh ngạc mà họ sẽ theo dõi, theo cách tương tự như Peter Jackson đã làm với Lord of the Rings. Đây chính là những điều chúng tôi muốn mang lại.', N'2', N'5', N'5', N'2', N'1')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P06', N'Aquaman and the Lost Kingdom', N'145p', N'C13', N'chưa cập nhật', N'3', N'4', N'1', N'5', N'1')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P07', N'Khang Khoai Lang', N'100p', N'C13', N'Đó là một ngày đẹp trời', N'1', N'1', N'4', N'6', N'4')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P08', N'Gone With the Wind', N'240p', N'C16', N'Bộ phim chuyển thể từ tiểu thuyết cùng tên của Margaret Mitchell đã giành 10 giải Oscar và là bộ phim tình cảm vĩ đại được hàng triệu người mến mộ. “Gone with the Wind”  kể câu chuyện về cuộc đời chìm nổi của Scarlett O’Hara (Vivien Leigh), một phụ nữ quý tộc miền Nam vật lộn tìm cách sống sót qua cơn bão táp của cuộc nội chiến và thời kỳ tái thiết. Scarlett đem lòng yêu Ashley (Leslie Howard), một quý tộc kỳ lạ nhiều lý tưởng, nhưng chàng lại lấy cô em họ Melanie (Olivia de Havilland) hiền dịu làm vợ. Scarlett không bỏ cuộc, vẫn tìm mọi cách để theo đuổi Ashley nhưng dần dần nàng vướng vào mối tình định mệnh với Rhett Butler (Clark Gable), một tay chơi bất cần nhưng chân thành. ', N'4', N'7', N'7', N'7', N'1')
INSERT [dbo].[Phim] ([MaPhim], [TenPhim], [ThoiLuong], [GioiHanTuoi], [NoiDungChinh], [MaTheLoai], [MaDienVien], [MaDaoDien], [MaNhaSX], [MaNuocSX]) VALUES (N'P09', N'Titanic', N'194p', N'C13', N' Lại một siêu phẩm nữa của James Cameron, tàu Titanic đắm và cái chết của Jack là nỗi đau của nàng Rose khi còn sống và chứng kiến người mình yêu chết để cứu mình cũng chính là nỗi đau của khán giả khi chứng kiến một nhân vật vô cùng đáng mến đã không thể sống sót để bảo vệ tình yêu. Nhưng mặc dù nó mang đến nỗi buồn vô tận cho khán giả, cái kết đó chính là chiến thắng của nghệ thuật theo lời Cameron. Một bộ phim dù qua hơn hai mươi năm vẫn hay từ hình ảnh đến âm nhạc thì không thể nào phủ nhận được sự cháy vé khi bộ phim này ra rạp là kinh khủng tới mức nào!
', N'4', N'8', N'5', N'2', N'1')
GO
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'1', N'Hành Động')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'2', N'Khoa Học Viễn Tưởng')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'3', N'Siêu Anh Hùng')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'4', N'Tình Cảm')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'5', N'Kinh Dị')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'6', N'Hành Động Quỷ Quái')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'7', N'Kinh Công')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'8', N'Khang Việt Nam')
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_DaoDien] FOREIGN KEY([MaDaoDien])
REFERENCES [dbo].[DaoDien] ([MaDaoDien])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_DaoDien]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_DienVien] FOREIGN KEY([MaDienVien])
REFERENCES [dbo].[DienVien] ([MaDienVien])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_DienVien]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_NhaSanXuat] FOREIGN KEY([MaNhaSX])
REFERENCES [dbo].[NhaSanXuat] ([MaNhaSX])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_NhaSanXuat]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_NuocSanXuat] FOREIGN KEY([MaNuocSX])
REFERENCES [dbo].[NuocSanXuat] ([MaNuocSX])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_NuocSanXuat]
GO
ALTER TABLE [dbo].[Phim]  WITH CHECK ADD  CONSTRAINT [FK_Phim_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Phim] CHECK CONSTRAINT [FK_Phim_TheLoai]
GO
