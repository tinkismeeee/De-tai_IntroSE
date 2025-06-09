let popup = document.getElementById('popup')
function openPopup(){
  popup.classList.add('open-popup')
}

function closePopup(){
  popup.classList.remove('open-popup')
}

var swiper = new Swiper('.swiper-container', {
  loop: true, // Lặp vô tận
  spaceBetween: 10, // Khoảng cách giữa các slide
  navigation: {
  nextEl: '.swiper-button-next',
  prevEl: '.swiper-button-prev',
  },
  pagination: {
  el: '.swiper-pagination',
  clickable: true,
  },
});
