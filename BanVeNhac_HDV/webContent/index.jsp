<%@ page language="java" contentType="text/html; charset=utf-8"
	pageEncoding="utf-8"%>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport"
	content="width = device-width, initial-scales = 1.0">
<title>Black Pink</title>
<link rel="stylesheet" href="./assets/callAPI/api.js">
<link rel="stylesheet" href="./assets/css/style.css">
<link rel="stylesheet"
	href="./assets/fonts/themify-icons/themify-icons.css">

<link rel="stylesheet" href="./assets/callAPI/api.js">

</head>

<body>
	<div id="main">
		<div id="header">
			<!-- begin nav -->
			<ul id="nav">
				<li><img class="logo" src="./assets/imgs/logo/logo2.webp"
					alt=""stylte:{height: 46px;}></li>

				<li><a href="#">Home</a></li>
				<li><a href="#content">Band</a></li>
				<li><a href="#tour">Tour</a></li>
				<li><a href="#contact">Contact</a></li>
				<!-- <li>
                        <a href="#">
                            More
                            <i class="ti-angle-down"></i>
                        </a>
                        <ul class="subnav">
                            <li><a href="#">Merchandise</a></li>
                            <li><a href="#">Extras</a></li>
                            <li><a href="#">Media</a></li>
                        </ul>
                    </li> -->
			</ul>
			<!-- end nav -->

			<!-- begin search 
			<div class="search-btn">
				<i class="search-icon ti-search"></i>
			</div>-->
			<!-- end search -->
		</div>

		<div class="slide">
			<!-- Thẻ Chứa Slideshow -->
			<div class="slideshow-container">

				<!-- Kết hợp hình ảnh và nội dung cho mội phần tử trong slideshow-->
				<div class="mySlides fade">
					<div class="numbertext">1 / 3</div>
					<img src="./assets/imgs/slides/slide1.webp" width="100%">
					<!-- <div class="text">Nội Dung 1</div> -->
				</div>
				<div class="mySlides fade">
					<div class="numbertext">2 / 3</div>
					<img src="./assets/imgs/slides/slide2.jpg" width="100%">
					<!-- <div class="text">Nội Dung 2</div> -->
				</div>
				<div class="mySlides fade">
					<div class="numbertext">3 / 3</div>
					<img src="./assets/imgs/slides/slide3_2.jpg" width="100%">
					<!-- <div class="text">Nội Dung 3</div> -->
				</div>
				<!-- Nút điều khiển mũi tên-->
				<a class="prev" onclick="plusSlides(-1)">❮</a> <a class="next"
					onclick="plusSlides(1)">❯</a>

				<!-- Nút tròn điều khiển slideshow-->
				<div class="nut" style="text-align: center">
					<span class="dot" onclick="currentSlide(1)"></span> <span
						class="dot" onclick="currentSlide(2)"></span> <span class="dot"
						onclick="currentSlide(3)"></span>
				</div>
			</div>
		</div>


	</div>

	<script>
			var slideIndex = 1;
			showSlides(slideIndex);
			function plusSlides(n) {
				showSlides(slideIndex += n);
			}
			function currentSlide(n) {
				showSlides(slideIndex = n);
			}
			function showSlides(n) {
				var i;
				var slides = document.getElementsByClassName("mySlides");
				var dots = document.getElementsByClassName("dot");
				if (n > slides.length) { slideIndex = 1 }
				if (n < 1) { slideIndex = slides.length }
				for (i = 0; i < slides.length; i++) {
					slides[i].style.display = "none";
				}
				for (i = 0; i < dots.length; i++) {
					dots[i].className = dots[i].className.replace(" active", "");
				}
				slides[slideIndex - 1].style.display = "block";
				dots[slideIndex - 1].className += " active";
			}
		</script>

	<div id="content">
		<div class="content-section">
			<h2 class="header-section">BLACK PINK</h2>
			<p class="header-sub-section">We love music</p>
			<p class="text-content">BLACKPINK (블랙 핑크) gồm 4 thành viên:
				Jisoo, Jennie, Rosé và Lisa. Ban nhạc ra mắt vào ngày 8 tháng 8 năm
				2016 dưới YG Entertainment. Vào ngày 23 tháng 10 năm 2018, BLACKPINK
				đã chính thức ký hợp đồng với công ty Interscope Records của Hoa Kỳ.

				BLACKPINK Fandom Name: BLINK BLACKPINK Official Fan Colors: Black &
				Pink (Không được công bố chính thức, nhưng được sử dụng chính thức
				trên logo và hàng hóa của nhóm) Blackpink (Hangul: 블랙 핑크), viết tắt
				là BLACKPINK hoặc BLΛƆKPIИK, là một nhóm nhạc nữ Hàn Quốc được thành
				lập bởi YG Entertainment và là nhóm nhạc nữ đầu tiên ra mắt cùng một
				công ty giải trí sau 2NE1. Nhóm bao gồm bốn thành viên: Jennie,
				Lisa, Jisoo và Rosé. Họ chính thức ra mắt vào ngày 8 tháng 8 năm
				2016 với album đơn Square One. Những người hâm mộ Blackpink được gọi
				là "Blink". Tên fandom Blink có nghĩa là chúng ta bắt đầu bằng
				Blackpink và kết thúc bằng Blackpink. (BL)ACKP(INK).</p>

			<div class="member-list" id="member-list">
				<div class="member-item"></div>
				<!-- ========================================= -->
				<!-- ========================================= -->
				<!-- =============================hiện thành viên============ -->

				<!-- ========================================= -->
				<!-- ========================================= -->

			</div>
		</div>
	</div>

	<div id="tour">
		<div class="content-section">
			<h2 class="header-section">TOUR DATES</h2>
			<p class="header-sub-section">Remember to book your tickets!</p>

			<ul class="ticket-list">
				<li class="ticket-item">september
					<p class="status">Sout out</p>
					<p class="sub-status">3</p>
				</li>
				<li class="ticket-item">October
					<p class="status">Sout out</p>
					<p class="sub-status">3</p>
				</li>
				<li class="ticket-item">November
					<p class="status">Sout out</p>
					<p class="sub-status">3</p>
				</li>
			</ul>

			<div class="ticket-place-list" id="ticket-place-list">
				<!-- ========================================= -->
				<!-- ========================================= -->
				<!-- =============================hiện đặt vé============ -->

				<!-- ========================================= -->
				<!-- ========================================= -->


			</div>
		</div>
	</div>

	<div id="contact">
		<div class="content-section">
			<h2 class="header-section">CONTACT</h2>
			<p class="header-sub-section">Fan? Drop a note</p>

			<div class="contact-content">
				<div class="contact-info">
					<p>
						<i class="ti-location-pin contact-info-item"></i>Seoul, Korea
					</p>
					<p>
						<i class="ti-mobile contact-info-item"></i>Phone: <a
							href="tel:+00 151515">+00 151515</a>
					</p>
					<p>
						<i class="ti-email contact-info-item"></i>Email: <a
							href="mailto:mail@mail.com"> mail@mail.com</a>
					</p>
				</div>

				<div class="contact-form">
					<form action="">
						<div class="form-top">
							<div class="name form-top-item">
								<input type="text" name="" placeholder="Name"
									class="form-control">
							</div>
							<div class="email form-top-item">
								<input type="text" name="" placeholder="Email"
									class="form-control">
							</div>
						</div>

						<div class="form-botton">
							<input type="text" name="" placeholder="Messenge"
								class="form-control">
						</div>

						<input class="form-submit-btn" type="submit" value="SEND">
					</form>
				</div>

			</div>
		</div>
	</div>
	<div id="footer">
		<div class="social-contac">
			<a class="social-icon ti-facebook" href=""></a> <a
				class="social-icon ti-instagram" href=""></a> <a
				class="social-icon ti-skype" href=""></a> <a
				class="social-icon ti-pinterest-alt" href=""></a> <a
				class="social-icon ti-twitter-alt" href=""></a> <a
				class="social-icon ti-linkedin" href=""></a>

		</div>

	</div>

	<!-- =======================================testAPI=================================== -->
	<!-- =======================================testAPI=================================== -->
	<!-- =======================================testAPI=================================== -->
	<!-- =======================================testAPI=================================== -->
	<!-- =======================================testAPI=================================== -->
	<!-- =======================================testAPI=================================== -->



	<ul id="list-courses">


		<script src="./assets/callAPI/api.js"></script>


	</ul>










	<div class="model">
		<div class="model-contaner">
			<div class="js-model-close model-close">
				<i class="ti-close"></i>
			</div>

			<div class="model-header">
				<i class="ti-bag"></i> Tickets
			</div>

			<div class="model-body">

				<div class="info-member_block">
					<div class="info-member_left">
						<div class="model-info">
							<label for=""> <i class="ti-shopping-cart"></i> Loại vé
							</label> <label for="" class="normal_ticket typeTicket"> <input
								type="radio" id="normal" name="choose_ticket" value="100000">
								<label for="NORMAL" class="typeTicket">Vé Thường</label>
							</label> <label for="" class="vip_ticket typeTicket"> <input
								type="radio" id="vip" name="choose_ticket" value="150000">
								<label for="VIP" class="typeTicket">Vé Vip</label>
							</label> <label for="" class="vvip_ticket typeTicket"> <input
								type="radio" id="vvip" name="choose_ticket" value="180000">
								<label for="VVIP" class="typeTicket">Vé VVip</label>
							</label>
						</div>

						<div class="model-info">
							<label for=""> <i class="ti-money"></i> Giá vé
							</label> <label class="Ticket_price" id="giaVe"></label>

						</div>
						<div class="model-info">
							<label for=""> <i class="ti-infinite"></i> Số lượng
							</label> <label
								style="color: sienna; padding-left: 40px; padding-right: 40px">
								<input type="radio" name="quantity" id="one" value="1" />1
							</label> <label
								style="color: sienna; padding-left: 40px; padding-right: 40px">
								<input type="radio" name="quantity" id="two" value="2" />2
							</label> <label
								style="color: sienna; padding-left: 40px; padding-right: 40px">
								<input type="radio" name="quantity" id="three" value="3" />3
							</label>

						</div>
						<div class="model-info">
							<label for=""> <i class="ti-mobile"></i> SDT
							</label> <input id="SDT" type="text" placeholder="SDT?"
								class="model-input">
						</div>




					</div>


					<div class="info-member_right">
						<div class="model-info">
							<label><i class="ti-notepad"></i>Chi tiết: </label> <label
								id="details"></label>
						</div>
					</div>
				</div>

				<div class="card-info">
					<div class="model-info flex-left">
						<label for=""> <i class="ti-credit-card"></i> Số tài khoản
						</label> <input id="STK" type="text" placeholder="Số tài khoản?"
							class="model-input">
					</div>
					<div class="model-info flex-right">
						<label for=""> <i class="ti-lock"></i> Số Pin
						</label> <input id="PIN" type="password" placeholder="Số Pin?"
							class="model-input">
					</div>
				</div>

				<div class="model-info">
					<label for=""> <i class="ti-receipt"></i> Thành Tiền
					</label> <label for="" class="cost" id="cost"></label>
				</div>

				<div class="tbnPay">
					<button class="model-pay-btn" id="pay">
						Pay <i class="ti-check"></i>
					</button>
				</div>

			</div>

			<div class="model-footer">
				<div class="model-help">
					Need <a href="">help?</a>
				</div>
			</div>
		</div>

	</div>

	<div class="model_member_infor">
		<div class="model_member-contaner">
			<div class="js-model-close model-close js-close-memberInfo">
				<i class="ti-close"></i>
			</div>
			<div class="model_member-header">
				<p class="header_title">profile</p>
			</div>
			<div
				style="height: 1px; background-color: #ccc; flex: auto; margin: 15px;"></div>
			<div class="model_member-body">
				<div class="profile_img">
					<img class="profile_member_img" id="profile_member_imgg" src=""
						alt="member image">
				</div>

				<div class="profile_info" id="profile_info">
					<div class="name" id="name">Nghệ danh:</div>
					<div class="age" id="fullName">Tên khai sinh:</div>
					<div class="weight" id="bd">Ngày sinh:</div>
					<div class="heghtt" id="nationality">Quốc tịch:</div>
					<div class="heghtt" id="DebutDate">Ngày Debut:</div>
					<div class="heghtt" id="life">Tiểu Sử:</div>

					<div class="profile_info_contact">
						<div class="heghtt ti-instagram">
							<a href="" id="instagram"> instagram</a>
						</div>
						<div class="heghtt ti-twitter">
							<a href="" id="twitter">twitter</a>
						</div>
					</div>
				</div>
			</div>
			<div
				style="height: 1px; background-color: #ccc; flex: auto; margin: 0 15px 15px 15px;"></div>
			<div class="model_member-footer"></div>
		</div>
	</div>

	<div id="name">1.</div>

	<div class="modal_bill">

		<div class="modal_bill-container">
			<div
				class="js-model-close model-close js-close-memberInfo js-close-Bill">
				<i class="ti-close"></i>
			</div>
			<div class="modal_bill-header">
				<div class="modal_bill-title">HÓA ĐƠN</div>

			</div>
			<div
				style="height: 1px; background-color: #ccc; flex: auto; margin: 15px;"></div>
			<div class="modal_bill-body">
				<div class="modal_bill-place modal_bill-item" id="modal_bill-place">Địa
					Điểm:</div>
				<div class="modal_bill-listTicket modal_bill-item"
					id="modal_bill-listTicket">Danh sách mã số vé:</div>
				<div class="modal_bill-price modal_bill-item" id="modal_bill-price">Giá:
				</div>
				<div class="modal_bill-billID modal_bill-item"
					id="modal_bill-billID">mã hóa đơn:</div>
				<div class="modal_bill-transDate modal_bill-item"
					id="modal_bill-transDate">Ngày giao dịch:</div>
				<div class="modal_bill-sdt modal_bill-item" id="modal_bill-sdt">SDT:
				</div>
				<div class="modal_bill-quantity modal_bill-item"
					id="modal_bill-quantity">Số lượng:</div>
				<div class="modal_bill-typeTicket modal_bill-item"
					id="modal_bill-typeTicket">Loại vé:</div>
				<div class="modal_bill-showName modal_bill-item"
					id="modal_bill-showName">Tên show:</div>
				<div class="modal_bill-time modal_bill-item" id="modal_bill-time">Thời
					gian biểu diễn:</div>
			</div>
			<div
				style="height: 1px; background-color: #ccc; flex: auto; margin: 15px;"></div>
			<div class="modal_bill-footer">
				<div class="modal_bill-contact">Thông tin liên hệ: 0500654886</div>
			</div>
		</div>
	</div>





	<script>
		 
         
         
<!-- =============================================show thong tin ve=============================================== -->
<!-- =============================================show thong tin ve=============================================== -->


		 // Lấy đối tượng
		var idLoaiVe ;
		var SoLuong;
        var normal = document.getElementById("normal");
        var vip = document.getElementById("vip");
        var vvip = document.getElementById("vvip");
        // Thêm sự kiện cho đối tượng
        normal.addEventListener('click', function(){
        	 document.getElementById('giaVe').innerHTML = normal.value;
        	 console.log(normal.value);
        	//keo value gia ve tu api len
        	
        	var postAPI ='https://localhost:44315/api/show/loai-ve'
        		return fetch(postAPI)
				.then(function(response){
					return response.json();
					//== json.parse
				})
				.then(function(posts){
					var htmls = posts.map(function(post){
		                if(post.idLoaiVe == 1){
		                   // document.getElementsByClassName('typeTicket').innerHTML=post.tenLoai;
		                    document.getElementById('details').innerHTML=post.chiTiet;		
		                    idLoaiVe = post.idLoaiVe ;	                   
		                }
				});
			});
            // Gán giá trị vào div
          
            
        });
        
        
        
        vip.addEventListener('click', function(){
        	//keo value gia ve tu api len
        	var postAPI ='https://localhost:44315/api/show/loai-ve'
			fetch(postAPI)
				.then(function(response){
					return response.json();
					//== json.parse
				})
				.then(function(posts){
					var htmls = posts.map(function(post){
		                if(post.idLoaiVe == 2){
		                   // document.getElementById('typeTicket').innerHTML=`${post.tenLoai}`;
		                    document.getElementById('details').innerHTML=post.chiTiet;
		                    idLoaiVe = post.idLoaiVe;
		                }				                
				});
			});
        	
        	
            // Gán giá trị vào div
            document.getElementById('giaVe').innerHTML = vip.value;
        });	
        
        vvip.addEventListener('click', function(){
        	//keo value gia ve tu api len
        	var postAPI ='https://localhost:44315/api/show/loai-ve'
			fetch(postAPI)
				.then(function(response){
					return response.json();
					//== json.parse
				})
				.then(function(posts){
					var htmls = posts.map(function(post){
		                if(post.idLoaiVe == 3){
		                  //  document.getElementById('typeTicket').innerHTML=`${post.tenLoai}`;
		                    document.getElementById('details').innerHTML=post.chiTiet;
		                    idLoaiVe = post.idLoaiVe;
		                }				                
				});
			});
        	
        	// Gán giá trị vào div
        	document.getElementById('giaVe').innerHTML = vvip.value
        })
        
	
         						
<!-- =============================================set tong luong tien ve can tra======================== -->
<!-- =============================================set tong luong tien ve can tra======================== -->
			
		 					var one = document.getElementById("one");
				            var two = document.getElementById("two");
				            var three = document.getElementById("three");
				            one.addEventListener('click', function(){
								
								var giaVe = document.getElementById("giaVe").innerHTML;
								document.getElementById("cost").innerHTML = giaVe*one.value;
								SoLuong = one.value;
						      })
						      
						      two.addEventListener('click', function(){
								
								var giaVe = document.getElementById("giaVe").innerHTML;
								document.getElementById("cost").innerHTML = giaVe*two.value;
								SoLuong = two.value;
						      })
				            
				            three.addEventListener('click', function(){
								
								var giaVe = document.getElementById("giaVe").innerHTML;
								document.getElementById("cost").innerHTML = giaVe*three.value;
								SoLuong = three.value;
						      });
				           
				 

				            
				         
          
      </script>

	</div>


</body>
</html>