console.log("JavaScript initialised successfully.");
function downloadPage() {
  try {
    const htmlContent = document.documentElement.outerHTML; //Retrieve HTML content (full)
    const blob = new Blob([htmlContent], { type: "text/html" }); //binary data (blob)
    const link = document.createElement("a");
    link.href = URL.createObjectURL(blob);
    link.download = "placeholder.html";
    link.addEventListener("click", () => {
      console.log("Attempting Download...");
      alert("Download Started... (this will enable offline viewing)");
    });
    link.click();
  } catch (error) {
    console.error("Download failed because of ", error);
    alert("Download failed; check in the browser console for more information.");
  }
}

//Examples below
//Add to page: <button class="download-page">Use Offline</button> (the important bit is that the HTML element has the download-page class, the rest is just an example)
//Add to page: document.querySelector(".download-page").addEventListener("click", downloadPage);
