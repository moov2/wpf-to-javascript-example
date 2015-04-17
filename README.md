# wpf-to-javascript-example
Quick proof to test communicating between C# and JS via the WebBrowser control


## List of IE vesions:

11001 (0x2EDF) 

Internet Explorer 11. Webpages are displayed in IE11 Standards mode, regardless of the !DOCTYPE directive.

11000 (0x2AF8) 

Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.

10001 (0x2AF7) 

Internet Explorer 10. Webpages are displayed in IE10 Standards mode, regardless of the !DOCTYPE directive.

10000 (0x2710)

Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.

9999 (0x270F) 

Internet Explorer 9. Webpages are displayed in IE9 Standards mode, regardless of the !DOCTYPE directive.

9000 (0x2328) 

Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.

8888 (0x22B8) 

Webpages are displayed in IE8 Standards mode, regardless of the !DOCTYPE directive.

8000 (0x1F40) 

Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode.

7000 (0x1B58) 

Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode.

You'll also need to render the page using IE's Edge rendering engine, this'll need to be set on the page being loaded, else WPF will default to compatibility mode and possibly fail calling Javascript objects.
