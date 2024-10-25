# Hours

Hours is a scrappy time tracker with some added niceties. It's a work in progress, so specifications and features are prone to change.

Hours uses icons from the Silk icon set, under CC-Attribution terms:
http://www.famfamfam.com/lab/icons/silk/
https://github.com/legacy-icons/famfamfam-silk

## Requirements

Windows, .NET Framework 4.0. Visual Studio 2010 or later used to build.

Tentatively upcoming:
[ ] Port to .NET MAUI?
[ ] Remote web interface?

## Features

### Projects

Projects or Activities store your sessions, and can optionally be placed into categories for grouping related activities. They're all displayed along the left side of the Hours window, and can be added from the bottom left.

Projects are color coded based on recent activity.

| Color         | Meaning                                    |
| ------------- | -------------------------------------------|
| Gray          | Inactive (No sessions in the last 7 days)  |
| Black         | Active this week |
| Blue          | Active yesterday |
| Teal          | Active today |
 
A project can be grouped into a category with the "Set category..." option on its secondary click menu. In this context menu, recent activity indicators can be disabled with the "Mark today's activities" option. A project can be renamed by double clicking its name in the project view.

Projects are arranged alphabetically. Categories don't have any particular order beyond what the ListView feels like.

Tentatively upcoming:
[ ] Welcome screen before you've selected a session (avoid a crash).
[ ] Rearranging project groups.
[ ] Persisting "Categories", "Comment View", "Mark today's activities" options across launches.
[ ] Fine tuning what features are used globally or per activity 
(ratings, average, attachments, 7-day tracker etc)

### Attachments

Projects can keep a record of files and Internet links related to them. Clicking the attachments icon (the cursor turns into a crosshair when hovered) will toggle the panel's height, expanding to full size or hidden entirely.

Dragging a file or link into the Attachments pane will add a shortcut to that resource in the project. Giving the attachment two spaced-out clicks allows it to be renamed.

Attachments that are not available locally (i.e. for files that have been deleted, or reference a path on a different computer) are greyed out.


Attachments are a work in progress feature. Tentatively upcoming:
[ ] Editing attachments' path and icon (functional Attachments dialog).
[ ] Removing attachments.
[ ] Changing the order of attachments.
[ ] Grouping attachments, such as for multiple weeks or routines.
[ ] Reordering those groups.

### Sessions

Sessions are recorded blocks of time. Their details can be viewed per project on a timeline view in the right side of the window, and a recorded Session contributes to an added up total on the bottom right, alongside today's total. The timeline is grouped by day, with sessions sorted in ascending order. Selecting multiple sessions in the timeline sums them up in a selected time tally where today's total would be.

The last 7 days' activity is displayed in the project view below the stopwatch in a "habit tracker" kind of format. White denotes no activity, green denoting recorded sessions.

Tentatively upcoming:
[ ] Daily time amounts.
[ ] Highlighting that day's activities in the timeline when a day in the tracker is clicked.

#### Timing a session

A Session is started by hitting the Start button, and then concluded by hitting the Pause (or Log) button. Pointing the mouse on the hourglass icon (below the pause button) displays the elapsed time in H:MM format.

Tentatively upcoming:
[ ] Offsetting start times (started earlier).

#### Reviewing sessions

After a session is recorded it's displayed in the timeline. Double clicking the session, which has now shown up with a "add comment" icon, brings up the session's details window, used for writing a description of what was done (Comment), giving a subjective quality score (Rating), and adjusting the duration (offset the end time). When either a comment is written or the session is given a rating, the symbol becomes a book-ish report icon.

The timeline has two views: the default Comment view, which displays an excerpt of the session's description, with a tooltip on hover indicating the start time, end time, and duration; and the formerly default view that displays the start time of the session, with comment and duration in the tooltip.

Entering a comment, a newline can be added while holding down the shift key and pressing return. It can be a simple indicator of what was worked on or light notes for recall. This may affect interop, see below.

#### Rating sessions

Sessions aren't rated by default. Should you choose to rate your sessions, an average rating is given on the top-right of the screen. 

Note that this average is not weighed by the length of the session in any capacity, only the rating given. The average rating is grayed if the activity hasn't had activity in 7 days.

| Value   | Icon   
| ------- | ------ | 
| ---       |   ---    |
| 1       | Stormy |
| 2       |        |
| 3       | Cloudy |
| 4       |        |
| 5       | Sunny  |

### Measuring time

Hours can also quickly visualize two times on the bottom left of the window. When two times are input, with the current moment in range, the progress bar will update to account for it. It can be used for Pomodoro, etc.

This is separate from recording sessions though - this is a timer (countdown) feature, while that behaves more as a stopwatch (count up).

Tentatively upcoming:
[ ] Working correctly with past ranges (100%) or next-day end times.

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

Hours also has CSV export for certain other applications (script arrow icon adjacent to the Save button). This saves all data as CSV records, with email optionally available for Toggl Track format. This is a lossy conversion as newlines aren't supported on this platform and some fields aren't used.

```csv
Project	Description,Start date,Start time,Duration
Spanish reading,En territorio salvaje,7/29/2024,13:43:39,0:05:32
```