# ImgToMp4Utility

Standalone app for converting a folder of numbered images into a mp4 video sequence.

## Usage
Click on "releases" on the right and download the latest release. Save the .exe somewhere it belongs, then just run it.

## Why is such a small file so big?
- WinForms does not support [trimming](https://learn.microsoft.com/en-us/dotnet/core/deploying/trimming/incompatibilities?source=recommendations#windows-forms) so it's got a lot of things it doesn't need bundled up.
- It has an internal copy of FFmpeg (that it dumps to your appdata/temp folder on first launch). Almost all of FFmpeg is not required for this app to do what it does. It uses a compiled FFmpeg 4.4.1 binaries for windows 64bit.
- It was important for me for the app to exist as a no-install standalone exe that you could delete and forget about, and where you didn't need to install ffmpeg separately. I could have made it a lot smaller if these considerations were not so important.

## License Information
This software uses code of [FFmpeg](http://ffmpeg.org) licensed under the [LGPLv2.1](http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html) and its source is available on this page.
