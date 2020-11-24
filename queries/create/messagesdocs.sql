CREATE TABLE messagesdocs
(
    --m = message
    m_id VARCHAR(8) NOT NULL,
    doc VARCHAR(12) NOT NULL,
    PRIMARY KEY(m_id, doc)
);