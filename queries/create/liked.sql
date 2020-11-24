CREATE TABLE liked
(
    --u = user
    u_id VARCHAR(8) NOT NULL,
    --n = note
    n_id VARCHAR(8) NOT NULL,
    PRIMARY KEY(u_id, n_id)
);