$(function () {
      // // jQuery goes here...

      // // Fade out element over 2000ms
      // $(".red-box").fadeOut(2000);

      // // Fade back in over 1000ms
      // $(".red-box").fadeIn(1000);

      // // Fade element to specific opacity (here 50%)
      // $(".blue-box").fadeTo(1000, 0.5);

      // // Note that the blue box animation starts right away, whereas the second
      // // red box animation waits until the first animation finished.
      // // This is because each element has its own animation queue which is
      // // executed one after the other. So while the red box is still "busy" with
      // // its first animation, the second animation waits in the queue.

      // // Fade element in or out, depending on current status
      // $(".blue-box").fadeToggle();
      // $(".blue-box").fadeToggle();

      // // Notice that fadeToggle fades back to the blue box's previous opacity,
      // // thus only back to 50% opacity.

      // // Uncomment this line to fade out the red box on page load
      // // $(".red-box").fadeOut(2000);
      // // $(".green-box").fadeOut("Fast");
      // // $(".blue-box").fadeOut("slow");

      // // $(".red-box").fadeIn(4000);
      // // $(".green-box").fadeIn("Fast");
      // // $(".blue-box").fadeIn("slow");

      // // $(".red-box").fadeTo(2000,0.5);
      // // $(".green-box").fadeTo(2000,0.5);
      // // $(".blue-box").fadeTo(2000,0.5);

      // $(".red-box").fadeToggle();
      // $(".green-box").fadeToggle();
      // $(".blue-box").fadeToggle();

      // $(".red-box").fadeToggle();
      // $(".green-box").fadeToggle();
      // $(".blue-box").fadeToggle();




      //  // Fade out element over 2000ms
      //  $(".red-box").fadeOut(2000);

      //  // Try to use fadeTo
      //  $(".red-box").fadeTo(1000, 1.0);

      //  // This doesn't work because fadeOut() will set display: none and fadeTo
      //  // doesn't modify the display property. Thus, it's not able to make it
      //  // reappear.

      //  // Back to original state
      //  $(".red-box").fadeIn(100);

      //  // To keep red box in the layout, use only fadeTo
      //  $(".red-box").fadeTo(2000, 0);

      //  // Can now make it re-appear in the way we tried above
      //  $(".red-box").fadeTo(1000, 1.0);



      // // Hide an element
      // $(".red-box").hide();

      // // Show it again
      // $(".red-box").show();

      // // Just toggle visibility depending on whether element is shown or hidden
      // $(".red-box").toggle();  // hides

      // // Up until this point, you can't even see what happens in the browser
      // // because it happens in a matter of milliseconds.

      // // Use show/hide as animations (not very commonly used)
      // $(".green-box").hide(1000);
      // $(".green-box").show(1000);



      //  // Slide element up to hide (over 2s)
      //  $(".blue-box").slideUp(2000);

      //  // Slide back down to show element
      //  $(".blue-box").slideDown(2000);

      //  // Toggle sliding up/down depending on current state
      //  $(".blue-box").slideToggle(1000);
      //  $(".blue-box").slideToggle(1000);



      // // Custom animation to move element by gradually increasing margin to 200px
      // $(".green-box").animate({
      //   "margin-left": "+=200px"
      // });

      // // Reset
      // $(".green-box").animate({
      //   "margin-left": "0px"
      // });

      // // Move element by gradually increasing margin BY 200px (using +=)
      // // (no matter what it was before)
      // $(".green-box").animate({
      //   "margin-left": "+=200px"
      // });

      // // Define animation duration (here 2s)
      // // Default duration is 300ms
      // $(".green-box").animate({
      //   "margin-left": "-=200px"
      // }, 2000);

      // // Define animation progression function
      // // Linear updates the margin-left linearly
      // // $(".green-box").animate({
      // //   "margin-left": "+=200px"
      // // }, 2000, "linear");

      // $(".green-box").animate({
      //   "margin-left": "+=200px"
      // }, 2000, "swing");



      // // Animate various CSS properties of the blue box
      // $(".blue-box").animate({
      //   marginLeft: "200px",
      //   opacity: "0",
      //   height: "50px",
      //   width: "50px",
      //   marginTop: "25px"
      // }, 1000);

      // // Animate font size of all paragraphs
      // $("p").animate({
      //   "font-size": "20px",
      // }, 1000);



      // // Fade out red box immediately to 50% opacity (over 1 second)
      // $(".red-box").fadeTo(1000, 0.5);

      // // Wait 1 second, then fade out green box to 50% opacity (over 1 second)
      // // This already using function chaining to call .fadeTo() directly on the
      // // return value of .delay()
      // $(".green-box").delay(1000).fadeTo(1000, 0.5);

      // // Chaining even more function calls to create animation
      // $(".blue-box").delay(2000).fadeTo(1000, 0.5).fadeTo(1000, 1.0).delay(1000).fadeOut();

      // // $(".red-box").fadeTo(1000, 0.5,function(){
      // //   alert("fadeTo")
      // // });

      // $(".green-box").fadeTo(1000, 0.5,function(){
      //   $(".red-box").fadeTo(1000, 0.5,function(){
      //     $(".blue-box").fadeTo(1000, 0.5);
      //   });
      // });



      //  // Fade out red box over 100 second
      //  $(".red-box").fadeTo(1000, 0, function() {

      //   // This callback function is executed once outer animation finishes.
      //   // So the green box starts fading out once the red box finished fading out.
      //   $(".green-box").fadeTo(1000, 0, function() {

      //     // Similarly, any code inside this function will start executing only once
      //     // the green box finishes fading out (after 2 seconds)
      //     $(".blue-box").fadeTo(1000, 0);
      //   });
      // });




      // // Fade in lightbox after half a second
      // $(".lightbox").delay(500).fadeIn(1000);




      //  // NOTE: Some of the selectors below overlap. To see the exact effect of one
      //   // of them, please comment out all others.

      //   // To select elements in jQuery, you can simply use any CSS selector inside
      //   // the $() function by passing it in as a string.

      //   // Select all paragraph tags
      //   var p = $("p");
      //   highlight(p);

      //   // Select all elements with the class .red-box (only one in this case)
      //   var redBoxes = $(".red-box");
      //   highlight(redBoxes);

      //   // Select the unique element with ID "list"
      //   var list = $("#list");
      //   highlight(list);

      //   // Select all h2, p, and input tags
      //   var elements = $("h2, p, input");
      //   highlight(elements);

      //   // Select only the last <li> on the page
      //   var lastItem = $("li:last");
      //   highlight(lastItem);

      //   // Select all even list items on the page (every second list item)
      //   var everySecondItem = $("li:even");
      //   highlight(everySecondItem);

      //   // Select all odd list items (every other list item)
      //   var everyOtherItem = $("li:odd");
      //   highlight(everyOtherItem);

      //   // Select all input elements that are checked/selected
      //   // Checkboxes and radio buttons don't have background-color
      //   var selected = $("input:checked");
      //   console.log(selected.length);

      //   // Select all input elements of type email
      //   var emails = $("input[type=email]");
      //   highlight(emails);





      // // NOTE: Some of the selectors below overlap. To see the exact effect of one
      //   // of them, please comment out all others.

      //   // Select the #list and find all <li> tags it contains
      //   // This contains even indirect children further down in the hierarchy
      //   var items = $("#list").find("li");
      //   highlight(items);

      //   // Select the #list and find only <li> that are *direct* children
      //   // Note that this will still produce a yellow background around the whole list
      //   // because the direct children <li> have enough height to contain their children
      //   var children = $("#list").children("li");
      //   highlight(children);

      //   // Search for even non-direct parents
      //   var body = $("#list").parents("body");
      //   highlight(body);

      //   // Select the (unique) direct parent of an element
      //   var content = $("#list").parent();
      //   // highlight(content);

      //   // Search through siblings on the same level in the HTML hierarchy
      //   var siblingHeadlines = $("#list").siblings(":header");
      //   highlight(siblingHeadlines);

      //   // Select the previous sibling of a selected element
      //   var previous = $("#list").prev();
      //   highlight(previous);

      //   // Select the next sibling of a selected element
      //   var next = $("#list").next();
      //   highlight(next);





      // // NOTE: Some of the selectors below overlap. To see the exact effect of one
      // // of them, please comment out all others.

      // // Select all <li> tags and then filter out all odd ones (keep only even ones)
      // // Same as $("#list > li:even"), using more advanced CSS
      // var everySecondItem = $("#list").children("li").filter(":even");
      // highlight(everySecondItem);

      // // The filter can even be a function that gets the index of an element and
      // // returns true (to keep the element) or false (to filter it out).
      // // For instance, to select only every third sub list item, we can do this:
      // var everyThirdItem = $("li li").filter(function(index) {
      //   return index % 3 == 0;
      // });
      // highlight(everyThirdItem);

      // // Keep only the first item of a selection
      // var first = $("li").first();
      // highlight(first);

      // // Keep only the last item of a selection
      // var last = $("li").last();
      // highlight(last);

      // // Keep only the item at a specific index of a selection
      // // For instance, keep only the 5th item (thus index 4):
      // var fifth = $("li").eq(4);
      // highlight(fifth);

      // // Keep only the second last item (index -2):
      // var secondLast = $("li").eq(-2);
      // highlight(secondLast);

      // var secondLast = $("li").not(function (index) {
      //   return index%3===2;
      // });

      // highlight(secondLast);



      // 1) Appending elements to existing elements.
      // -> This adds elements as the last children of a given element

      // Append a new list item to the end of the first sub list
      // $("ul ul:first").append("<li>New sub item</li>");

      // // Other way to achieve the same effect
      // $("<li>Another new sub item</li>").appendTo("ul ul:first");

      // // 2) Prepending elements to existing elements.
      // // -> This adds elements as the first children of a given element

      // // Prepend a new list item to the start of the first sub list
      // $("ul ul:first").prepend("<li>First sub item</li>");

      // // Other way to achieve the same effect
      // $("<li>Very first sub item</li>").prependTo("ul ul:first");

      // $("<h4>Very first sub item</h4>").prependTo("#content");

      // // 3) Adding elements as siblings of existing elements

      // // Add a new elements after an existing one (as next sibling)
      // $(".red-box").after("<div class='red-box'>New Red</div>");

      // // Add a new elements before an existing one (as previous sibling)
      // $(".blue-box").before("<div class='blue-box'>New Blue</div>");

      // // You can also use a callback function to construct more complex
      // // elements to add to the DOM
      // $(".green-box").after(function() {
      //   // Maybe more complex string of new element(s)
      //   return "<div class='green-box'>New Green</div>";
      // });

      // // 4) Add existing elements to other existing elements
      // // -> This will move the added element, so the original vanishes

      // // For instance, add the #list after the first paragraph (removes it from its
      // // original position).
      // // In case it's added to multiple elements, jQuery must clone the added element.
      // $("p:first").after($("#list"));




      // // Replace each selected item with another one.
      //   // For instance, replace all <p> tags with another one.
      //   $("p:first").replaceWith("<p>I've been replaced.</p>")

      //   // Again, to construct more complex elements, you may want
      //   // to do that in a callback function:
      //   $("p:last").replaceWith(function() {
      //     return "<p>Complex new paragraph...</p>";
      //   });

      // Also, you can again replace an element with another existing
      // element which will remove it from its original position.
      // $(".red-box").replaceWith($(".blue-box"));

      // You can also replace multiple items at the same time.
      // $("li:first, li:last").replaceWith("<li>First or last list item</li>");

      // $("<div class='green-box'>More Green</div>").replaceAll($(".red-box , .blue-box"));





      // // You can remove an existing element simply with remove().
      // // For instance, the first main item:
      // $("li:first").remove();

      // // If you want to reuse/re-display the element later, you should
      // // use detach(). This also keeps all attached event handlers alive.
      // // First, this removes the element from the DOM:
      // var detached = $("p:first").detach();
      // // Next, this will re-attach the element to the DOM (at another position):
      // $("#list").after(detached);

      // // To remove all elements *inside* a given elements, you can use empty().
      // // The element itself remains in the DOM, so in this case the <form>.
      // $("form").empty();


      // // $(".red-box,.blue-box").empty();
      // $(".red-box,.blue-box").detach();




      // // 1) Attributes with attr()

      // // To read the current value of an attribute, use attr() with only
      // // one argument: the name of the attribute you want to read.
      // var link = $("#link");
      // // Retrieve the value of the href attribute of the <a> tag
      // // This is logged into the console. To see it, press F12 in Firefox/Chrome
      // // to open the Developer Tools and click on the Console tab.
      // console.log(link.attr("href"));
      // // Log the value of the title attribute
      // console.log(link.attr("title"));

      // // To set the value of an attribute, you call the attr() function with two
      // // arguments: first, the name of the attribute you want to change, and second
      // // the new value:
      // link.attr("href", "http://petersommerhoff.com");

      // // 2) Properties with prop()

      // // To read the *current* value of a checkbox for instance, you must use the
      // // prop() function:
      // var radioButton = $("input[type=radio]:first");
      // console.log(radioButton.prop("checked"));  // false
      // console.log(radioButton.attr("checked"));  // undefined

      // // 3) Values with val()
      // // -> Read or set the value attribute of input elements

      // // To retrieve the value of an input element, simply call val()
      // var email = $("input[type=email]").val();
      // console.log(email);  // i@mine.me
      // var number = $("input[type=range]").val();
      // console.log(number);  // 3

      // // To set a new value, pass the new value as an argument to val():
      // $("input[type=text]").val("Peter Sommerhoff");
      // $("input[type=range]").val(9);

      // // If you have multiple elements selected, using val() will implicitly
      // // always call first() beforehand, so only change the first input element:
      // var value = $("input").val();
      // console.log(value);  // Peter Sommerhoff







      // // Select the <img> inside the gallery to manipulate it later
      // var galleryImage = $(".gallery").find("img").first();

      // // Initialize an array of all images for the gallery
      // var images = [
      //   "images/laptop-mobile_small.jpg",
      //   "images/laptop-on-table_small.jpg",
      //   "images/people-office-group-team_small.jpg"
      // ];

      // // Now, we want to cycle through all images we have and show one after the
      // // other in our gallery. For this, we create a variable i: the index of the
      // // image we want to currently show.
      // var i = 0;

      // // setInterval will call whatever code is inside the callback function every
      // // 2 seconds. This way, we can change the shown image every 2 seconds.
      // setInterval(function() {
      //   // First, we update the index i to the next image.
      //   // However, we cannot simply do i = i+1 because that would quickly result in
      //   // indexes i = 3, 4, 5 etc which are invalid for our array.
      //   // So we constrain the sequence to the range 0..2 by using modulo 3 (i % 3).
      //   console.log((i + 1) );

      //   i = (i + 1) % images.length;  // i = 1, 2, 0, 1, 2, 0, ...

      //   // console.log(images.length);
      //   // console.log(images); 
      //   console.log(i);
      //   // Now, we just have to change the src attribute of the <img> to the next
      //   // image we want to show.
      //   // To achieve a smooth transition, we'll actually first fadeOut the old,
      //   // then update the src attribute behind the scenes, and then fade it back in.
      //   galleryImage.fadeOut(function() {
      //     // Inside the callback, "this" refers to the galleryImage
      //     $(this).attr("src", images[i]);
      //     $(this).fadeIn();
      //   });

      //   // Log current image path for debugging
      //   console.log(galleryImage.attr("src"));

      // }, 2000);




      // // To retrieve or set the value of a CSS property, you can use css().
      //   // This works similar to attr() and prop(): pass one argument to read
      //   // or two arguments to set a new value.

      //   // For instance, you can achieve the same as with hide() like this:
      //   $("p:first").css("display", "none");

      //   // Let's read the width property of .red-box:
      //   var redBox = $(".red-box");
      //   console.log(redBox.css("width"));  // 80px
      //   // To get the width or height without unit, you can use width() and height():
      //   console.log(redBox.width());  // 80

      //   // You can change any CSS property in this simple way.
      //   redBox.css("background-color", "#AA5500");
      //   $("p").css("font-size", "20px");

      //   // You can even change the value of a property relative to its previous value
      //   redBox.css("width", "+=20px");
      //   redBox.css("height", "-=20px");

      //   // Also, you can retrieve multiple values by passing an array as the argument
      //   var properties = $("p").css(["font-size", "line-height", "color"]);
      //   // The result is an object containing all values
      //   console.log(properties);
      //   console.log(properties["font-size"]);  // 20px

      //   // In line with jQuery's other function, you can also use a callback function
      //   // instead of passing in a new value directly.
      //   // This example also demonstrates that jQuery automatically uses the correct
      //   // vendor prefix for the CSS property depending on the browser, which is
      //   // -moz-user-select in this case.
      //   // You can see that in the Developer Tools (F12 in browser) in the Inspector tab.
      //   // redBox.css("user-select","none");
      //   redBox.css("user-select", function() {
      //     // [some logic here...]
      //     return "none";
      //   });




      //  // Additional CSS classes can be added to an element via addClass()

      //   // For instance, add the class .fancy-link to all anchor tags.
      //   // Note that you *do not* add a dot in front of the class name here.
      //   $("a").addClass("fancy-link");

      //   // You can also add multiple classes at once.
      //   $("p:first").addClass("large emphasize");

      //   // To attach a class based on the index of the element in your selected
      //   // set of elements, you can use a callback function.
      //   $("li li").addClass(function(index) {
      //     // This adds classes .item-0, .item-1, ... to the list's sub-items.
      //     $(this).addClass("item-" + index);
      //   });

      //   // You can even use two parameters for the callback function, the index
      //   // and the current class of the element.
      //   $("div").addClass(function(index, currentClasses) {
      //     console.log(currentClasses);  // String containing all classes

      //     // Add .red-box if the current classes contain "dummy"
      //     if (currentClasses.indexOf("dummy") !== -1) {
      //       return "red-box";
      //     }
      //   });

      //   // You can again chain these calls to switch one class for another.
      //   $(".green-box").removeClass("green-box").addClass("red-box");

      //   // To quickly toggle one particular CSS class, use toggleClass().
      //   $("li li:first").toggleClass("emphasize");





      //  // jQuery allows you to attach arbitrary data to any element, represented as
      //   // HTML attributes prefixed with "data-", e.g. "data-images".
      //   // Here, we'll attach data about all available images to the gallery itself.

      //   // Select the <img> inside the gallery to manipulate it later
      //   var gallery = $(".gallery");

      //   // Initialize an array of all images for the gallery
      //   var images = [
      //     "images/laptop-mobile_small.jpg",
      //     "images/laptop-on-table_small.jpg",
      //     "images/people-office-group-team_small.jpg"
      //   ];

      //   // To attach data, use the data() function and pass in two arguments: first,
      //   // the key for the data, and second the actual data/value.
      //   gallery.data("availableImages", images);
      //   // To retrieve the data, again use just one argument: the key.
      //   console.log(gallery.data("availableImages"));  // Array[...]

      //   gallery.data("name", "The Amazing Gallery");
      //   console.log(gallery.data("name"));  // The Amazing Gallery

      //   // Remove data just as easily using removeData().
      //   gallery.removeData("name");
      //   console.log(gallery.data("name"));  // undefined

      //   // If you attach data directly in HTML via an attribute prefixed with "data-",
      //   // you can read that automatically from jQuery.
      //   var data = $("p:first").data("mydata");
      //   console.log(data);  // Data coming from HTML attribute




      // // 1) Pure text content: text()

      //   // To read or change the textual content of an element, you use text().
      //   var p = $("p:first");
      //   console.log(p.text());  // Lorem ipsum...

      //   p.text("Now it's a very short paragraph.");
      //   console.log(p.text());  // Now it's a very short paragraph.

      //   // 2) HTML content: html()

      //   // In contrast to text(), html() allows you to retrieve the content of an
      //   // element including the HTML code of its content/children.
      //   var p2 = $("p").eq(1);  // Second <p> tag
      //   console.log(p2.text());  // Lorem ipsum...
      //   console.log(p2.html());  // <span>Lorem</span> ipsum ...

      //   // Similarly, you can set the HTML content of an element with html()
      //   // whereas text() would escape the HTML code to make it show as text.
      //   $("li ul").eq(0).text("<li>Not an item</li>");
      //   $("li ul").eq(1).html("<li>Correct item</li>");

      //   // You can use this in a way that appends content to an element.
      //   p2.text(p2.text() + " This is an additional sentence.");
      //   p2.html(p2.html() + " <span class='emphasize'>And another emphasized one.</span>");




      // // Click handler can be attached by passing a callback function to the click()
      //   // function. Whatever code you write into the callback function is then
      //   // executed whenever the user clicks the element.
      //   // You can add a parameter to the callback to retrieve additional info about
      //   // the event. Accordingly, we call the parameter "event".
      //   $("#btn-click").click(function(event) {
      //     console.log(event);
      //     alert("Thanks for clicking me!");
      //   });

      //   // As always in jQuery, inside the callback, you can refer to the element
      //   // as $(this).
      //   $(".red-box").click(function() {
      //     var currentOpacity = $(this).css("opacity");
      //     $(this).fadeTo(500, currentOpacity - 0.2);
      //   });

      //   // You can even simulate click events on the element by calling click()
      //   // without any arguments.
      //   $(".red-box").click();




      // // Hover handlers are defined the same way as click handlers but using hover().
      // // Hover events fire as soon as the cursor enters *or* leaves the element.
      // $("#button").hover(function(event) {
      //   console.log(event);
      //   alert("You hovered me!");
      // })

      // // And you can again refer to the element as $(this) from within the callback.
      // $(".green-box").hover(function() {
      //   $(this).text("Hovered!");
      // });  





      //  // While hover() with one callback function triggers both when entering and
      //   // leaving the element with the cursor, mouseenter() and mouseleave() allow
      //   // you to attach different event handlers for both.
      //   $(".blue-box").mouseenter(function() {
      //     $(this).stop().fadeTo(500, 0.5);
      //   });

      //   $(".blue-box").mouseleave(function() {
      //     $(this).stop().fadeTo(500, 1);
      //   });

      //   // However, you can achieve the same with hover() as well. For this, you must
      //   // pass in two callback functions: first the one for mouseenter, then the one
      //   // for mouseleave.
      //   // So the following does the same as  the above, but for the red box:
      //   //hover(handlerIn,handlerOut)
      //   $(".red-box").hover(function() {
      //     $(this).stop().fadeTo(500, 0.5);
      //   }, function() {
      //     $(this).stop().fadeTo(500, 1);
      //   });






      // // You can attach the same handler (callback function) for multiple events
      //   // using jQuery's on() function.
      //   // For instance, the following logs to the console whenever you click anywhere
      //   // on the page or press any key while the page/browser is focused.
      //   $("html").on("click keydown", function() {
      //     console.log("Mouse was clicked or key was pressed.");
      //   });

      //   // Let's use this to add a gallery that switches to the next image on click.
      //   var images = [
      //     "images/laptop-mobile_small.jpg",
      //     "images/laptop-on-table_small.jpg",
      //     "images/people-office-group-team_small.jpg"
      //   ];

      //   // The following is the same as in the image slideshow code, except we now
      //   // use a click event instead of setTimeout().
      //   var i = 0;
      //   $(".gallery").find("img").on("click", function() {
      //     i = (i + 1) % images.length;
      //     $(this).fadeOut(function() {
      //       $(this).attr("src", images[i]).fadeIn();
      //     });
      //   });








      // // You can modularize your code into smaller functions by defining the
      //   // callback function explicitly instead of passing it in.

      //   // Directly passing in callback as before. We call this callback an *anonymous
      //   // function* because it doesn't have a name.
      //   $("html").on("click keydown", function() {
      //     console.log("Mouse was clicked or key was pressed.");
      //   });

      //   // Using named function as a callback (this function is defined at the end of
      //   // this file).
      //   $("html").on("click keydown", logEvent);

      //   // Let's use this to add a gallery that switches to the next image on click.
      //   var images = [
      //     "images/laptop-mobile_small.jpg",
      //     "images/laptop-on-table_small.jpg",
      //     "images/people-office-group-team_small.jpg"
      //   ];

      //   // For this function, it makes more sense to modularize it because the
      //   // callback is more complex.
      //   // To do this, we store the gallery image in a variable so that we can use it
      //   // in the switchToNextImage() function instead of $(this). Using $(this)
      //   // would still work but would make the function harder to read and understand.
      //   var i = 0;
      //   var galleryImage = $(".gallery").find("img")
      //   galleryImage.on("click", switchToNextImage);

      //   // In contrast to logEvent(), this is a nested function (it's nested into our
      //   // main jQuery function). This way, we can access galleryImage.
      //   function switchToNextImage() {
      //     i = (i + 1) % images.length;
      //     galleryImage.fadeOut(function() {
      //       galleryImage.attr("src", images[i]).fadeIn();
      //     });
      //   }







      // // The event handlers you've used so far are only attached to those elements
      //   // that exist at the time the code is executed. Thus, they won't work for
      //   // dynamically attached elements:
      //   $("p").click(function() {
      //     $(this).slideUp();
      //   });
      //   $("#list").before("<p>This is a dynamically added paragraph</p>");

      //   // To solve this, you can use delegated events. Here, you attach the handler
      //   // to a parent element that will always exist on the page. When the event
      //   // comes in, the parent then delegates the event to all defined children.
      //   // For this, you must use the on() function, and pass in which children should
      //   // handle the event. For instance, all <li> tags inside #content:
      //   $("#content").on("click", "li li", function() {
      //     $(this).slideUp();
      //   });

      //   $("#list ul").append("<li>Dynamically added new item!</li>");

      // $("body").on("mouseenter","li",function () {
      //   $(this).css("color","#666");
      // });






      // // For all the event handlers you've learned, you can pass in an additional
      // // first argument to attach extra data to the event object. This extra data
      // // is passed as a JavaScript object, which is encompassed by curly braces:
      // $("#button").click({
      //   user: "Peter",
      //   domain: "http://petersommerhoff.com"
      // }, function(event) {
      //   console.log(event.data);  // event.data carries the extra data: user and domain

      //   // Here, we call our function greetUser() and pass in the event data as
      //   // its argument.
      //   greetUser(event.data);
      // });

      // // The function greetUser() accepts one parameter with user data (this will
      // // be event.data) so that we can access it inside the function.
      // function greetUser(userdata) {
      //   // Uses the user from the event data, or "Anonymous" if none is defined.
      //   username = userdata.user || "Anonymous";
      //   domain = userdata.domain || "example.com";

      //   alert("Welcome back " + username + " from " + domain + "!");
      // }







      // // These are now multiple images.
      // var galleryItems = $(".gallery").find("img");

      // // Normally, you would do this in CSS.
      // galleryItems.css("width", "30%")
      //             .css("opacity", "0.7");

      // // Fade images in/out when hovering/leaving.
      // galleryItems.mouseenter(function() {
      //   $(this).stop().fadeTo(500, 1);
      // });

      // galleryItems.mouseleave(function() {
      //   $(this).stop().fadeTo(500, 0.7);
      // });

      // // Preview image in lightbox when clicked.
      // galleryItems.click(function() {
      //   // Read image src of clicked image.
      //   var source = $(this).attr("src");

      //   // Generate new <img> tag to add to the lightbox.
      //   var newImage = $("<img>").attr("src", source).css("width", "100%");

      //   // Prepare and show lightbox preview.
      //   $(".lightbox").empty().append(newImage).fadeIn(1000);
      // });

      // // Exit lightbox preview when clicking it anywhere.
      // $(".lightbox").click(function() {
      //   $(this).stop().fadeOut();
      // });





      //  // To handle key presses, use keydown().
      //   // Usually, you'll attach this to the <html> tag so that the event is handled
      //   // whenever a key is pressed on the page.
      //   $("html").keydown(function(event) {
      //     // You normally want to use the event argument here to do something based
      //     // on which key was pressed. This information is stored in event.which.
      //     console.log(event.which);
      //   });

      //   // Looking at the log of event.which, we can see that the arrow right key
      //   // corresponds to 39. So let's store this info to make the code readable:
      //   var ARROW_RIGHT = 39;

      //   // Now let's move the blue box when the user presses the arrow right key.
      //   $("html").keydown(function(event) {
      //     if (event.which === ARROW_RIGHT) {
      //       $(".blue-box").stop().animate({
      //         marginLeft: "+=10px"
      //       }, 50);
      //     }
      //   });







      // // Select inputs
      // var inputFields = $("input:text, input:password, textarea");

      // // Add grey box shadow when focusing any input using focus().
      // inputFields.focus(function() {
      //   $(this).css("box-shadow", "0 0 4px #666");
      // });

      // // Conversely, remove box shadow from other inputs when unfocusing them
      // // using blur().
      // inputFields.blur(function() {
      //   $(this).css("box-shadow", "none");
      // });

      // // Add green or red background to name field, depending on whether the input
      // // fulfills the validation criteria (here simply at least 3 characters)
      // $("#name").blur(function() {
      //   var text = $(this).val();
      //   console.log(text);
      //   if (text.trim().length < 3) {
      //     $(this).css("box-shadow", "0 0 10px #811");
      //   } else {
      //     $(this).css("box-shadow", "0 0 10px #181");
      //   }
      // });





      //  // The change event is used for input elements such as checkboxes, radio
      //   // button and select tags. They fire whenever the selection changes.

      //   // Add green indicator when checkbox is checked and red one otherwise.
      //   $("#checkbox").change(function() {
      //     var isChecked = $(this).is(":checked");  // or .prop("checked")

      //     if (isChecked) {
      //       // Add the checkbox' label to the selection and highlight both in green.
      //       $(this).add("label[for='checkbox']").css("box-shadow", "0 0 20px #181");
      //     } else {
      //       $(this).add("label[for='checkbox']").css("box-shadow", "0 0 20px #811");
      //     }
      //   });

      //   // Another common use case is to read the selected option from a <select>
      //   // element when a new option is selected.
      //   $("#selection").change(function() {
      //     var chosen = $(this).find(":selected").text();
      //     alert(chosen);
      //   });





      // // You can intercept form submission via the submit event.
      //   // jQuery provides the submit() for this. A common use case is to perform
      //   // client-side form validation to avoid submitting a form with invalid data.

      //   // For instance, let's check if the user wrote a message in the textarea.
      //   $("#form").submit(function(event) {
      //     console.log(event);
      //     var textarea = $("#message");
      //     if (textarea.val().trim() === "") {
      //       // No message, add red highlighting to indicate error
      //       textarea.css("box-shadow", "0 0 20px #811");

      //       // The default event now would be to submit the form. The browser will do
      //       // this automatically when clicking a submit button. We prevent this using
      //       // preventDefault(). This way, the form will not be submitted.
      //       event.preventDefault();
      //     } else {
      //       // Nothing to do, let the form be submitted.
      //     }
      //   });








      //  // When the submit event comes in, we first validate all form fields
      //   // and abort submission if one of them is invalid. Also, we highlight all
      //   // invalid fields so that the user knows what to fix.
      //   $("#form").submit(function(event) {
      //     // First, read out all entered values.
      //     var name = $("#name").val();
      //     var password = $("#password").val();
      //     var message = $("#message").val();
      //     var checked = $("#checkbox").is(":checked");

      //     // Then we use our validation functions (defined below) to check each input.
      //     validateNameField(name, event);
      //     validatePasswordField(password, event);
      //     validateMessageField(message, event);
      //     validateCheckboxField(checked, event);
      //   });

      //   // In the following, we define helper functions that each validate
      //   // one of the inputs. These will be used further down by our validation
      //   // functions.

      //   function isValidName(name) {
      //     return name.trim().length >= 2;
      //   }

      //   function isValidPassword(password) {
      //     return password.length >= 6 && /.*[0-9].*/.test(password);
      //   }

      //   function isValidMessage(message) {
      //     return message.trim() !== "";
      //   }

      //   // Next, we define the actual validation functions which use the helpers from
      //   // above. These validation functions add a hint for the user for each invalid
      //   // input and prevent the form from submitting if the input is invalid.

      //   // First, show a hint if the name is not valid or remove the hint if it's
      //   // now valid.
      //   function validateNameField(name, event) {
      //     if (!isValidName(name)) {
      //       $("#name-feedback").text("Please enter at least two characters");
      //       event.preventDefault();
      //     } else {
      //       $("#name-feedback").text("");
      //     }
      //   }

      //   // Do the same for the other inputs.
      //   function validatePasswordField(password, event) {
      //     if (!isValidPassword(password)) {
      //       $("#password-feedback").text("The password should have at least 6 characters and contain a number");
      //       event.preventDefault();
      //     } else {
      //       $("#password-feedback").text("");
      //     }
      //   }

      //   function validateMessageField(message, event) {
      //     if (!isValidMessage(message)) {
      //       $("#message-feedback").text("Please enter a message.");
      //       event.preventDefault();
      //     } else {
      //       $("#message-feedback").text("");
      //     }
      //   }

      //   function validateCheckboxField(isChecked, event) {
      //     if (!isChecked) {
      //       $("#checkbox-feedback").text("Please agree to this.");
      //       event.preventDefault();
      //     } else {
      //       $("#checkbox-feedback").text("");
      //     }
      //   }









      // // When the submit event comes in, we first validate all form fields
      //   // and abort submission if one of them is invalid. Also, we highlight all
      //   // invalid fields so that the user knows what to fix.
      //   $("#form").submit(function(event) {
      //     // First, read out all entered values.
      //     var name = $("#name").val();
      //     var password = $("#password").val();
      //     var message = $("#message").val();
      //     var checked = $("#checkbox").is(":checked");

      //     // Then we use our validation functions (defined below) to check each input.
      //     validateNameField(name, event);
      //     validatePasswordField(password, event);
      //     validateMessageField(message, event);
      //     validateCheckboxField(checked, event);
      //   });

      //   // == NEW PART ==
      //   // In addition to the previous form validation code, we now provide faster
      //   // feedback to the user, namely when moving to the next input element.
      //   enableFastFeedback($("#form"));

      //   function enableFastFeedback(formElement) {
      //     var nameInput = formElement.find("#name");
      //     var passwordInput = formElement.find("#password");
      //     var messageInput = formElement.find("#message");
      //     var checkboxInput = formElement.find("#checkbox");

      //     nameInput.blur(function() {
      //       var name = $(this).val();
      //       highlight($(this), isValidName(name));
      //     });

      //     passwordInput.blur(function() {
      //       var password = $(this).val();
      //       highlight($(this), isValidPassword(password));
      //     });

      //     messageInput.blur(function() {
      //       var message = $(this).val();
      //       highlight($(this), isValidMessage(message));
      //     });

      //     checkboxInput.change(function() {
      //       var isChecked = $(this).is(":checked");
      //       highlight($(this), isChecked);
      //     });
      //   }

      //   function highlight(element, isValid) {
      //     var color = "#811";  // red
      //     if (isValid) {
      //       color = "#181";  // green
      //     }

      //     element.css("box-shadow", "0 0 4px " + color);
      //   }

      //   // In the following, we define helper functions that each validate
      //   // one of the inputs. These will be used further down by our validation
      //   // functions.

      //   function isValidName(name) {
      //     return name.trim().length >= 2;
      //   }

      //   function isValidPassword(password) {
      //     return password.length >= 6 && /.*[0-9].*/.test(password);
      //   }

      //   function isValidMessage(message) {
      //     return message.trim() !== "";
      //   }

      //   // Next, we define the actual validation functions which use the helpers from
      //   // above. These validation functions add a hint for the user for each invalid
      //   // input and prevent the form from submitting if the input is invalid.

      //   // First, show a hint if the name is not valid or remove the hint if it's
      //   // now valid.
      //   function validateNameField(name, event) {
      //     if (!isValidName(name)) {
      //       $("#name-feedback").text("Please enter at least two characters");
      //       event.preventDefault();
      //     } else {
      //       $("#name-feedback").text("");
      //     }
      //   }

      //   // Do the same for the other inputs.
      //   function validatePasswordField(password, event) {
      //     if (!isValidPassword(password)) {
      //       $("#password-feedback").text("The password should have at least 6 characters and contain a number");
      //       event.preventDefault();
      //     } else {
      //       $("#password-feedback").text("");
      //     }
      //   }

      //   function validateMessageField(message, event) {
      //     if (!isValidMessage(message)) {
      //       $("#message-feedback").text("Please enter a message.");
      //       event.preventDefault();
      //     } else {
      //       $("#message-feedback").text("");
      //     }
      //   }

      //   function validateCheckboxField(isChecked, event) {
      //     if (!isChecked) {
      //       $("#checkbox-feedback").text("Please agree to this.");
      //       event.preventDefault();
      //     } else {
      //       $("#checkbox-feedback").text("");
      //     }
      //   }






      //  // You can load files from the server (or local file system in this case) with
      //   // jQuery using its load() function.
      //   // $("#code").load("js/script.js");

      //   // You can also handle different responses, for instance if an error occurred.
      //   $("#code").load("idontexist.php", function(response, status) {
      //     console.log(response);  // empty (normally contains the fetched contents)
      //     console.log(status);  // error

      //     if (status === "error") {
      //       // alert("Could not find idontexist.php");
      //     }
      //   });







      // // There are many APIs online that you can fetch data from. Many of these
      //   // return data in JSON or XML format. Here, we use the Flickr API to retrieve
      //   // image data as JSON (JavaScript Object Notation).

      //   // First, store the URL of the API.
      //   // The ?jsoncallback parameter is necessary to avoid cross-origin errors in
      //   // modern browsers (you're not generally allowed to fetch data from remote sites).
      //   var flickrApiUrl = "https://api.flickr.com/services/feeds/photos_public.gne?jsoncallback=?";

      //   // Next, we use jQuery's getJSON() function to access to API and retrieve data.
      //   $.getJSON(flickrApiUrl, {
      //     // tags: "sun, beach",
      //     tags: " beach",
      //     tagmode: "any",
      //     format: "json"
      //   }).done(function(data) {
      //     // Inside done(), you can work with the retrieved data.
      //     console.log(data);

      //     // Let's use jQuery $.each() function to create an <img> tag for each image .
      //     $.each(data.items, function(index, item) {
      //       console.log(item);  // Helpful to see what data you can access

      //       // Create new image and add to gallery.
      //       $("<img>").attr("src", item.media.m).appendTo("#flickr");

      //       // Stop after 5 images.
      //       if (index == 21) {
      //         return false;
      //       }
      //     });
      //   }).fail(function(response) {
      //     // Inside fail(), you can handle error cases.
      //     console.log(response);
      //     alert("AJAX call failed.");
      //   });






      // // As another example of AJAX calls in jQuery, we access the PokéAPI to build
      //   // a Pokédex.

      //   var pokeapi = "https://pokeapi.co/api/v2/generation/1";

      //   $.getJSON(pokeapi).done(function(data) {
      //     console.log(data);  // Explore available data in the Developer Tools Console
      //     $.each(data.pokemon_species, function(index, pokemon) {
      //       console.log(pokemon)
      //       // var name = capitalize(pokemon.name);
      //       var name = pokemon.name.charAt(0).toUpperCase()+pokemon.name.slice(1);
      //       var paragraph = $("<p>").html("Pokémon species no. " + (index+1) + " is " + pokemon.name+" "+name,);
      //       paragraph.appendTo("#pokedex");
      //     });
      //   }).fail(function() {
      //     // Handle error case
      //     console.log("Call to PokéAPI failed.");
      //   }).always(function() {
      //     // Will always be executed (in either case).
      //     console.log("Pokémon is awesome.")
      //   });





      // Let's further improve the Pokédex while diving deeper into AJAX with jQuery.
      var pokeapi = "https://pokeapi.co/api/v2/generation/1";
      var pokemonByName = "https://pokeapi.co/api/v2/pokemon/";

      $.getJSON(pokeapi).done(function (data) {
        console.log(data); // Explore available data in the Developer Tools Console
        $.each(data.pokemon_species, function (index, pokemon) {
          var name = capitalize(pokemon.name);

          // Add an additional link to show image of the Pokémon.
          var boldName = $("<strong>").text(name);
          var link = $("<a>")
            .attr("id", pokemon.name)
            .attr("href", "#")
            .append(boldName);

          var paragraph = $("<p>")
            .html("Pokémon species no. " + (index + 1) + " is ")
            .append(link);
          paragraph.appendTo("#pokedex");

          // Add handler to the link to fetch and display image.
          // The helper function showPokemon is defined below.
          link.click(function () {
            showPokemon(pokemon.name); // API needs the non-capitalized name
          });
        });
      }).fail(function () {
        // Handle error case
        console.log("Call to PokéAPI failed.");
      }).always(function () {
        // Will always be executed (in either case).
        console.log("Pokémon is awesome.")
      });

      // Only select this element once and store in variable.
      var detailsDiv = $("#pokemon-details");

      function showPokemon(name) {
        $.getJSON(pokemonByName + name).done(function (details) {
          console.log(details); // To explore data in browser

          // Show selected Pokémon in the details div.
          var image = $("<img>").attr("src", details.sprites.front_default);
          detailsDiv.empty()
            .append("<h2>" + capitalize(name) + "</h2>")
            .append(image);

        }).fail(function (error) {
          console.log("Could not retrieve details for " + name);
        });
      };


      });

    // Capitalizes a given string.
    function capitalize(str) {
      return str.charAt(0).toUpperCase() + str.slice(1);
    }

    // Normal, named function
    function logEvent() {
      console.log("Mouse was clicked or key was pressed.");
    }

    // Helper function which highlights the given element with yellow background
    function highlight(element) {
      element.css("background-color", "rgba(180, 180, 30, 0.8)");
    }
