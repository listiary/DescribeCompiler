========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://en.test.org/wiki/List_of_fabrics] <QpeudYXy> ->

	wool fabrics [https://en.test.org/wiki/Wool | wikipedia] <54vHCQwI>,
	cotton fabrics [https://en.test.org/wiki/Cotton] <Ll0bDtIQ>,
	silk fabrics [https://en.test.org/wiki/Silk | test.org]<6huM44Hm>,
	synthetic fabrics [https://en.test.org/wiki/Synthetic]<oAgVUPi0>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── T(LINK|'[https://en.test.org/wiki/List_of_fabrics] ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'QpeudYXy')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Wool | wikipedia] ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'54vHCQwI')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Cotton] ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'Ll0bDtIQ')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── T(LINK|'[https://en.test.org/wiki/Silk | test.org]')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'6huM44Hm')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── T(LINK|'[https://en.test.org/wiki/Synthetic]')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'oAgVUPi0')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')