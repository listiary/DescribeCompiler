========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> 
{icon | nutrients.png}
->

    fiber <ZxMvmqeZ> [https://www.notube.com/watch?v=hTui12lKus],
    water <xePTheNI> [https://www.notube.com/watch?v=hTui12lKus];

micronutrients [] {icon | micronutrients.png} <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'macronutrients ')
│   │   │   ├── tag
│   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   ├── T(DATA|'Zcm0y9mS')
│   │   │   │   └── T(RIGHT_ARROW|'> \r\n')
│   │   │   └── T(DECORATOR|'{icon | nutrients.png}\r\n')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(DATA|'fiber ')
│   │   │   │   │   ├── tag
│   │   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   │   ├── T(DATA|'ZxMvmqeZ')
│   │   │   │   │   │   └── T(RIGHT_ARROW|'> ')
│   │   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   │   └── item
│   │   │       ├── text_chunk
│   │   │       │   └── T(DATA|'water ')
│   │   │       ├── tag
│   │   │       │   ├── T(LEFT_ARROW|'<')
│   │   │       │   ├── T(DATA|'xePTheNI')
│   │   │       │   └── T(RIGHT_ARROW|'> ')
│   │   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   └── T(TERMINATOR|';\r\n\r\n')
│   └── expression
│       ├── item
│       │   ├── text_chunk
│       │   │   └── T(DATA|'micronutrients ')
│       │   ├── T(LINK|'[] ')
│       │   ├── T(DECORATOR|'{icon | micronutrients.png} ')
│       │   └── tag
│       │       ├── T(LEFT_ARROW|'<')
│       │       ├── T(DATA|'l7qy3zi2')
│       │       └── T(RIGHT_ARROW|'>')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   ├── text_chunk
│       │   │   │   │   └── T(DATA|'vitamins (ABCDEK) ')
│       │   │   │   └── tag
│       │   │   │       ├── T(LEFT_ARROW|'<')
│       │   │   │       ├── T(DATA|'6Nq8AWj7')
│       │   │   │       └── T(RIGHT_ARROW|'>')
│       │   │   └── T(SEPARATOR|',\r\n    ')
│       │   └── item
│       │       ├── text_chunk
│       │       │   └── T(DATA|'minerals (micronutrients) ')
│       │       └── tag
│       │           ├── T(LEFT_ARROW|'<')
│       │           ├── T(DATA|'jG4U9bwg')
│       │           └── T(RIGHT_ARROW|'>')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')