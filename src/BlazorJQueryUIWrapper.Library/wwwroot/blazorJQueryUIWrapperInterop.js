"use strict";

var blazorJQueryUIWrapperInterop = blazorJQueryUIWrapperInterop || {};

// jQuery Selector
blazorJQueryUIWrapperInterop.BQUI_Draggable = () => {

};

blazorJQueryUIWrapperInterop.BQUI_Spinner = (selector) => { $(selector).spinner(); };

// Utils
blazorJQueryUIWrapperInterop.BQUI_Utils_Alert = (message) => { alert(message); };
blazorJQueryUIWrapperInterop.BQUI_Utils_ConsoleLog = (message) => { console.log(message); };

