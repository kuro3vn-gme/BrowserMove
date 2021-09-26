mergeInto(LibraryManager.library, {
  ScreenWidth: function () {
    return window.screen.availWidth;
  },
  ScreenHeight: function () {
    return window.screen.availHeight;
  },
  WindowX: function () {
    return window.screenX || window.screenLeft;
  },
  WindowY: function () {
    return window.screenY || window.screenTop;
  },
});