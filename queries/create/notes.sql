CREATE TABLE notes
(
    note_id VARCHAR(8) NOT NULL,
    --user or group id
    id VARCHAR(8) NOT NULL,
    --the text content of the note
    content VARCHAR(256),
    PRIMARY KEY(note_id)
);