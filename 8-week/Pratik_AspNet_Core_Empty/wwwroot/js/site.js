// Sayfa yüklendiğinde çalışacak kodlar
document.addEventListener("DOMContentLoaded", function () {
  // Menü animasyonları
  const navLinks = document.querySelectorAll("nav a");

  navLinks.forEach((link) => {
    link.addEventListener("mouseover", () => {
      this.style.opacity = "0.8";
    });

    link.addEventListener("mouseout", () => {
      this.style.opacity = "1";
    });
  });
});
