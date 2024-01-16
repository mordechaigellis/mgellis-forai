update party set ColorId = (select colorid from color c where c.ColorName = 'Purple')
where PartyName = 'Democratic-Republican'

;
WITH x AS (
    SELECT
        'Democrat' AS PartyName,
        'One of the two major contemporary political parties in the United States, the Democratic Party has its historical roots in the Jeffersonian and Jacksonian democratic traditions, advocating for a stronger role of the federal government in economic and social matters.' AS PartyDesc
    UNION ALL
    SELECT
        'Democratic-Republican',
        'This party, also known as the Jeffersonian Republicans, was founded by Thomas Jefferson and James Madison. It emphasized states'' rights and advocated for a limited federal government, opposing policies of the Federalists.'
    UNION ALL
    SELECT
        'Federalist',
        'The Federalist Party was the first American political party, advocating for a strong national government and commercial economy. It was led by Alexander Hamilton and John Adams.'
    UNION ALL
    SELECT
        'National Union',
        'This was a coalition of the Republican Party and War Democrats during the American Civil War that supported Abraham Lincoln�s presidency. It emphasized the preservation of the Union and the abolition of slavery.'
    UNION ALL
    SELECT
        'None, Federalist',
        'This represents the early U.S. leaders who were unaffiliated with a formal political party but leaned towards Federalist policies, including a stronger central government and a loose interpretation of the Constitution.'
    UNION ALL
    SELECT
        'Republican',
        'The Republican Party, also known as the GOP (Grand Old Party), was formed by anti-slavery activists and modernizers. It traditionally promotes conservative and right-leaning policies, emphasizing free enterprise, individual rights, and limited government.'
    UNION ALL
    SELECT
        'Whig',
        'The Whig Party was formed in opposition to the policies of President Andrew Jackson and the Democrats. It advocated for the supremacy of Congress over the Presidency and favored modernization, banking, and economic protectionism.'
)
UPDATE p
SET p.PartyDesc = x.PartyDesc
FROM party p
join x ON p.PartyName = x.PartyName;
