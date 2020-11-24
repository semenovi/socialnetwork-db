CREATE TABLE outrequests
(
    id VARCHAR(8) NOT NULL,
    recipient_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(id, recipient_id)
);