const truckGallery = [
          {
            image: "./img/png/truck1.png",
            name: "Truck 1"
          },
          {
            image: "./img/png/truck2.png",
            name: "Truck 2"
          },
          {
            image: "./img/png/truck3.png",
            name: "Truck 3"
          },
          {
            image: "./img/png/truck4.png",
            name: "Truck 4"
          }
        ];
      
        const truckImage = document.querySelector("#truck-image");
        const truckName = document.querySelector("#truck-name");
        const prevButton = document.querySelector("#prev-button");
        const nextButton = document.querySelector("#next-button");
      
        let currentIndex = 0;
      
        function displayTruck(index) {
          truckImage.src = truckGallery[index].image;
          truckImage.alt = truckGallery[index].name;
          truckName.textContent = truckGallery[index].name;
        }
      
        displayTruck(currentIndex);
      
        nextButton.addEventListener("click", function() {
          currentIndex++;
          if (currentIndex >= truckGallery.length) {
            currentIndex = 0;
          }
          displayTruck(currentIndex);
        });
      
        prevButton.addEventListener("click", function() {
          currentIndex--;
          if (currentIndex < 0) {
            currentIndex = truckGallery.length - 1;
          }
          displayTruck(currentIndex);
        });