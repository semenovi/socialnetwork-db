CREATE TABLE inrequests
(
    id VARCHAR(8) NOT NULL,
    sender_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(id, sender_id)
);