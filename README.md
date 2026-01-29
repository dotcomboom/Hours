# Hours

Hours is a time tracker; it's a work in progress, so specifications and features are prone to change.

![](https://private-user-images.githubusercontent.com/38927017/540298732-e74b19ef-06f1-4c46-8f49-2e180f1a10df.png?jwt=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJnaXRodWIuY29tIiwiYXVkIjoicmF3LmdpdGh1YnVzZXJjb250ZW50LmNvbSIsImtleSI6ImtleTUiLCJleHAiOjE3NjkzOTY1NjEsIm5iZiI6MTc2OTM5NjI2MSwicGF0aCI6Ii8zODkyNzAxNy81NDAyOTg3MzItZTc0YjE5ZWYtMDZmMS00YzQ2LThmNDktMmUxODBmMWExMGRmLnBuZz9YLUFtei1BbGdvcml0aG09QVdTNC1ITUFDLVNIQTI1NiZYLUFtei1DcmVkZW50aWFsPUFLSUFWQ09EWUxTQTUzUFFLNFpBJTJGMjAyNjAxMjYlMkZ1cy1lYXN0LTElMkZzMyUyRmF3czRfcmVxdWVzdCZYLUFtei1EYXRlPTIwMjYwMTI2VDAyNTc0MVomWC1BbXotRXhwaXJlcz0zMDAmWC1BbXotU2lnbmF0dXJlPWU0NWY3YjA1YjViYWVhOTMyNGI5MTdmNDY0ZWYzN2Q0OTU2MDFlODM2MTRhYmVmZmU2YTI3MWY4NDYzZGMwMTMmWC1BbXotU2lnbmVkSGVhZGVycz1ob3N0In0.slDi9K6YivXyY7oFMCktFgHFGr_2uIijFAgsx-3tYCY)

## License
Hours source code is MIT licensed.

Hours uses icons from the Silk icon set, under CC-Attribution terms:
http://www.famfamfam.com/lab/icons/silk/
https://github.com/legacy-icons/famfamfam-silk

## Requirements

Windows, .NET Framework 4.0. VS 2010 or VS 2022 should be acceptable to build.

## Features

### Projects

Projects or Activities store your sessions, and can optionally be placed into categories for grouping related activities. They're all displayed along the right side of the Hours window, and can be added from the bottom right.
 
A project can be grouped into a category with the "Set category..." option on its secondary click menu. A project can be renamed by clicking its name twice in the project view.

Projects are arranged alphabetically. Categories have an order more representative of categories of the first projects added (at this time).

### Sessions

Sessions are recorded blocks of time. Their details can be viewed per project on a timeline view in the right side of the window, and a recorded Session contributes to an added up total on the bottom left, alongside today's total. The timeline is grouped by day, with sessions sorted in ascending order. Selecting multiple sessions in the timeline sums them up in a selected time tally where today's total would be.

#### Timing a session

A Session is started by hitting the Start button, and then concluded by hitting the Pause (or Log) button. Pointing the mouse on the pause button displays the elapsed time in H:MM format.

#### Reviewing sessions

After a session is recorded it's displayed in the timeline. Double clicking the session, which has now shown up with a "add comment" icon, brings up the session's details window, used for writing a description of what was done (Comment), giving a subjective quality score (Rating), and adjusting the duration (offset the end time). When either a comment is written or the session is given a rating, the symbol becomes a book-ish report icon.

The timeline has two views: the default Comment view, which displays an excerpt of the session's description, with a tooltip on hover indicating the start time, end time, and duration; and the formerly default view that displays the start time of the session, with comment and duration in the tooltip.

Entering a comment, a newline can be added while holding down the shift key and pressing return. It can be a simple indicator of what was worked on or light notes for recall. This may affect interop, see below.

#### Rating sessions

You can rate your sessions if you wish.

| Value   | Icon   
| ------- | ------ | 
| ---       |   ---    |
| 1       | Stormy |
| 2       |        |
| 3       | Cloudy |
| 4       |        |
| 5       | Sunny  |

## Dealing with Hours data

Hours saves and loads automatically as projects are updated, but there is a Save and Load button just in case. Be careful running multiple instances (such as on multiple computers through cloud
storage).

Hours data is saved to `hours_data.xml` in the same directory as the executable, in similar formatting to below.

```xml
<?xml version="1.0" encoding="utf-8"?>
<Projects>
  <Activity Name="...." Category="....">
    <Session>
      <StartTime>2024-07-29T13:43:39.1093750-05:00</StartTime>
      <EndTime>2024-07-29T13:49:11.1093750-05:00</EndTime>
      <Rating>(a whole number 1 through 5)</Rating>
      <Comment>......</Comment>
    </Session>
	....
    <Attachment>
      <Label>.......</Label>
      <Path>(Windows-style local path, or Internet URL)</Path>
      <ImageIndex>(number 0-15)</ImageIndex>
      <Index>0</Index>
    </Attachment>
  </Activity>
</Projects>
```

This can get fairly large (hundreds of KBs) with heavy use, so consider bandwidth if you choose to sync.
