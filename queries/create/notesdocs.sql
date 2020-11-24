CREATE TABLE notedocs
(
    --n = note
    n_id VARCHAR(8) NOT NULL,
    doc VARCHAR(12) NOT NULL,
    PRIMARY KEY(n_id, doc)
);